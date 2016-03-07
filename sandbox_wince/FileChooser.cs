////
/// Copyright (c) 2016 Saúl Piña <sauljabin@gmail.com>.
/// 
/// This file is part of xmlrpcwsc.
/// 
/// xmlrpcwsc is free software: you can redistribute it and/or modify
/// it under the terms of the GNU Lesser General Public License as published by
/// the Free Software Foundation, either version 3 of the License, or
/// (at your option) any later version.
/// 
/// xmlrpcwsc is distributed in the hope that it will be useful,
/// but WITHOUT ANY WARRANTY; without even the implied warranty of
/// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
/// GNU Lesser General Public License for more details.
/// 
/// You should have received a copy of the GNU Lesser General Public License
/// along with xmlrpcwsc.  If not, see <http://www.gnu.org/licenses/>.
////

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace sandbox_wince {
    public partial class FileChooser : Form {

        private bool accepted;
        private const string PathRoot = "\\";
        private const string GoBack = "..";
        private const string DefaultSearchPattern = "*";
        private const string SQLiteExtension = ".sqlite";
        private Dictionary<string, string> Translations;
        private Dictionary<string, string> DefaultTranslations;

        private enum FileIcon : int {
            File = 0,
            Directory,
            StorageCard,
            Back,
            Database
        }

        private enum FileType {
            File,
            Directory,
            StorageCard
        }

        private class PathWrapper {
            public string Name {
                get;
                set;
            }

            public string Path {
                get;
                set;
            }

            public PathWrapper() {
                Name = "";
                Path = "";
            }

            public PathWrapper(string name, string path) {
                Name = name;
                Path = path;
            }

            public override string ToString() {
                return Name;
            }
        }

        private string CurrentPath {
            set {
                if (value == null)
                    return;

                value = Path.GetFullPath(value);

                cmbPath.Items.Clear();

                string[] splitName = value.Split(Path.DirectorySeparatorChar);
                string acumPath = "";

                foreach (string splitPath in splitName) {
                    string temp = splitPath;

                    if (string.IsNullOrEmpty(splitPath))
                        temp = PathRoot;
                    else
                        temp = splitPath;

                    acumPath = Path.Combine(acumPath, temp);

                    PathWrapper path = new PathWrapper(temp, acumPath);
                    cmbPath.Items.Add(path);
                    cmbPath.SelectedItem = path;
                }
            }

            get {
                PathWrapper path = (PathWrapper)cmbPath.SelectedItem;
                return path.Path;
            }
        }

        public string SearchPattern {
            get;
            set;
        }

        public string CurrentFile {
            get {
                if (!string.IsNullOrEmpty(txtFileName.Text))
                    return Path.Combine(CurrentPath, txtFileName.Text);
                else
                    return string.Empty;
            }
        }

        public FileChooser() {
            InitializeComponent();
            InitializeFileChooser();
        }

        public void InitializeFileChooser() {
            this.Load += new System.EventHandler(this.FileChooser_Load);
            this.Closing += new System.ComponentModel.CancelEventHandler(this.FileChooser_Closing);
            DefaultTranslations = new Dictionary<string, string>();

            DefaultTranslations.Add("objects", "objects");
            DefaultTranslations.Add("up", "Up");
            DefaultTranslations.Add("name", "Name");
            DefaultTranslations.Add("accept", "Accept");

            SetTranslations(DefaultTranslations);
        }

        public void SetTranslations(Dictionary<string, string> translations) {
            if (translations != null)
                Translations = translations;
            else
                Translations = DefaultTranslations;

            lblName.Text = Translations["name"];
            mniAccept.Text = Translations["accept"];
            mniUp.Text = Translations["up"];
        }

        public void FileChooser_Closing(object sender, System.ComponentModel.CancelEventArgs e) {
            if (accepted)
                DialogResult = DialogResult.OK;
            else
                DialogResult = DialogResult.Cancel;
        }

        private void FileChooser_Load(object sender, System.EventArgs e) {
            SearchPattern = DefaultSearchPattern;
            CurrentPath = AppPath.GetAppPath();
        }

        private void btnReload_Click(object sender, EventArgs e) {
            Reload();
        }

        public void Reload() {
            Cursor.Current = Cursors.WaitCursor;

            listFiles.Items.Clear();
            string[] files = Directory.GetFiles(CurrentPath, SearchPattern);
            string[] directories = Directory.GetDirectories(CurrentPath);

            if (!CurrentPath.Equals(PathRoot)) {
                ListViewItem itemBack = new ListViewItem(GoBack);
                listFiles.Items.Add(itemBack);
                itemBack.ImageIndex = (int)FileIcon.Back;
            }

            foreach (string directory in directories) {
                ListViewItem item = new ListViewItem(Path.GetFileName(directory));
                item.ImageIndex = (int)GetFileIcon(directory);
                listFiles.Items.Add(item);
            }

            foreach (string file in files) {
                ListViewItem item = new ListViewItem(Path.GetFileName(file));
                item.ImageIndex = (int)GetFileIcon(file);
                listFiles.Items.Add(item);
            }

            txtFileName.Text = string.Empty;
            lblFilesCount.Text = (files.Length + directories.Length).ToString() + " " + Translations["objects"];

            Cursor.Current = Cursors.Default;
        }

        private void cmbPath_SelectedIndexChanged(object sender, EventArgs e) {
            Reload();
        }

        private void listFiles_ItemActivate(object sender, EventArgs e) {

            if (listFiles.SelectedIndices.Count <= 0)
                return;

            int index = listFiles.SelectedIndices[0];
            ListViewItem item = listFiles.Items[index];
            string relativePath = item.Text;

            if (relativePath.Equals(GoBack)) {
                CurrentPath = Path.GetDirectoryName(CurrentPath);
            } else {
                string absolutePath = Path.Combine(CurrentPath, relativePath);

                if (GetFileType(absolutePath).Equals(FileType.File)) {
                    txtFileName.Text = Path.GetFileName(absolutePath);
                } else {
                    CurrentPath = absolutePath;
                }
            }

        }

        private FileType GetFileType(string file) {
            FileInfo info = new FileInfo(file);
            FileAttributes attr = info.Attributes;

            if ((attr & (FileAttributes.Directory | FileAttributes.Temporary)) == (FileAttributes.Directory | FileAttributes.Temporary))
                return FileType.StorageCard;

            if ((attr & FileAttributes.Directory) == FileAttributes.Directory)
                return FileType.Directory;

            return FileType.File;
        }

        private FileIcon GetFileIcon(string file) {

            if (file.Equals(GoBack))
                return FileIcon.Back;

            if (GetFileType(file) == FileType.Directory)
                return FileIcon.Directory;

            if (GetFileType(file) == FileType.StorageCard)
                return FileIcon.StorageCard;

            if (Path.GetExtension(file).Equals(SQLiteExtension))
                return FileIcon.Database;

            return FileIcon.File;
        }

        private void mniUp_Click(object sender, EventArgs e) {
            if (CurrentPath.Length == 0 || CurrentPath == PathRoot)
                return;
            CurrentPath = Path.GetDirectoryName(CurrentPath);
        }

        private void mniAccept_Click(object sender, EventArgs e) {
            accepted = true;
            this.Close();
        }
    }
}