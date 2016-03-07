namespace sandbox_wince {
    partial class FileChooser {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.MainMenu mainMenu;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FileChooser));
            this.mainMenu = new System.Windows.Forms.MainMenu();
            this.mniUp = new System.Windows.Forms.MenuItem();
            this.mniAccept = new System.Windows.Forms.MenuItem();
            this.cmbPath = new System.Windows.Forms.ComboBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.listFiles = new System.Windows.Forms.ListView();
            this.ilistSmallIcons = new System.Windows.Forms.ImageList();
            this.btnReload = new System.Windows.Forms.PictureBox();
            this.lblFilesCount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.MenuItems.Add(this.mniUp);
            this.mainMenu.MenuItems.Add(this.mniAccept);
            // 
            // mniUp
            // 
            this.mniUp.Text = "Up";
            this.mniUp.Click += new System.EventHandler(this.mniUp_Click);
            // 
            // mniAccept
            // 
            this.mniAccept.Text = "Accept";
            this.mniAccept.Click += new System.EventHandler(this.mniAccept_Click);
            // 
            // cmbPath
            // 
            this.cmbPath.Location = new System.Drawing.Point(3, 3);
            this.cmbPath.Name = "cmbPath";
            this.cmbPath.Size = new System.Drawing.Size(210, 22);
            this.cmbPath.TabIndex = 0;
            this.cmbPath.SelectedIndexChanged += new System.EventHandler(this.cmbPath_SelectedIndexChanged);
            // 
            // lblName
            // 
            this.lblName.Location = new System.Drawing.Point(3, 165);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(48, 20);
            this.lblName.Text = "Name";
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(57, 164);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(180, 21);
            this.txtFileName.TabIndex = 2;
            // 
            // listFiles
            // 
            this.listFiles.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listFiles.FullRowSelect = true;
            this.listFiles.Location = new System.Drawing.Point(3, 31);
            this.listFiles.Name = "listFiles";
            this.listFiles.Size = new System.Drawing.Size(234, 115);
            this.listFiles.SmallImageList = this.ilistSmallIcons;
            this.listFiles.TabIndex = 3;
            this.listFiles.View = System.Windows.Forms.View.List;
            this.listFiles.ItemActivate += new System.EventHandler(this.listFiles_ItemActivate);
            this.ilistSmallIcons.Images.Clear();
            this.ilistSmallIcons.Images.Add(((System.Drawing.Image)(resources.GetObject("resource"))));
            this.ilistSmallIcons.Images.Add(((System.Drawing.Image)(resources.GetObject("resource1"))));
            this.ilistSmallIcons.Images.Add(((System.Drawing.Image)(resources.GetObject("resource2"))));
            this.ilistSmallIcons.Images.Add(((System.Drawing.Image)(resources.GetObject("resource3"))));
            this.ilistSmallIcons.Images.Add(((System.Drawing.Image)(resources.GetObject("resource4"))));
            // 
            // btnReload
            // 
            this.btnReload.Image = ((System.Drawing.Image)(resources.GetObject("btnReload.Image")));
            this.btnReload.Location = new System.Drawing.Point(215, 3);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(22, 22);
            this.btnReload.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // lblFilesCount
            // 
            this.lblFilesCount.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.lblFilesCount.Location = new System.Drawing.Point(114, 146);
            this.lblFilesCount.Name = "lblFilesCount";
            this.lblFilesCount.Size = new System.Drawing.Size(123, 18);
            this.lblFilesCount.Text = "Files Count";
            this.lblFilesCount.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // FileChooser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 188);
            this.Controls.Add(this.lblFilesCount);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.listFiles);
            this.Controls.Add(this.txtFileName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.cmbPath);
            this.Menu = this.mainMenu;
            this.Name = "FileChooser";
            this.Text = "FileChooser";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuItem mniUp;
        private System.Windows.Forms.MenuItem mniAccept;
        private System.Windows.Forms.ComboBox cmbPath;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.ListView listFiles;
        private System.Windows.Forms.ImageList ilistSmallIcons;
        private System.Windows.Forms.PictureBox btnReload;
        private System.Windows.Forms.Label lblFilesCount;
    }
}