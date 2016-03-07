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
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using XmlRpc;
using System.IO;

namespace sandbox_wince {

    public partial class SearchPartner : Form {

        public SearchPartner() {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e) {
            FileChooser fc = new FileChooser();
            if (fc.ShowDialog() == DialogResult.OK) {
                txtLogoCreate.Text = fc.CurrentFile;
            }
        }

        private byte[] ReadAllBytes(string fileName) {
            byte[] buff = null;
            FileStream fs = new FileStream(fileName,
                                           FileMode.Open,
                                           FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            long numBytes = new FileInfo(fileName).Length;
            buff = br.ReadBytes((int)numBytes);
            return buff;
        }

        private void btnCreate_Click(object sender, EventArgs e) {
            try {
                XmlRpcClient client = new XmlRpcClient();
                client.Url = txtUrl.Text;
                client.Path = "/xmlrpc/2/common";
                string db = txtDB.Text, user = txtUser.Text, pass = txtPass.Text;

                // LOGIN

                XmlRpcRequest requestLogin = new XmlRpcRequest("authenticate");
                requestLogin.AddParams(db, user, pass, XmlRpcParameter.EmptyStruct());

                XmlRpcResponse responseLogin = client.Execute(requestLogin);

                if (responseLogin.IsFault()) {
                    MessageBox.Show(responseLogin.GetFaultString(), "Error");
                    return;
                }

                // CREATE

                client.Path = "/xmlrpc/2/object";

                string imageBase64 = "";

                if (!string.IsNullOrEmpty(txtLogoCreate.Text))
                    imageBase64 = Convert.ToBase64String(ReadAllBytes(txtLogoCreate.Text));

                XmlRpcRequest requestCreate = new XmlRpcRequest("execute_kw");
                requestCreate.AddParams(db, responseLogin.GetInt(), pass, "res.partner", "create",
                    XmlRpcParameter.AsArray(
                        XmlRpcParameter.AsStruct(
                            XmlRpcParameter.AsMember("name", txtNameCreate.Text)
                            , XmlRpcParameter.AsMember("image", imageBase64)
                            , XmlRpcParameter.AsMember("email", txtEmailCreate.Text)
                        )
                    )
                );

                XmlRpcResponse responseCreate = client.Execute(requestCreate);

                if (responseCreate.IsFault()) {
                    MessageBox.Show(responseCreate.GetFaultString(), "Error");
                    return;
                } else {
                    MessageBox.Show("OK");
                }
            } catch (Exception ex) {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void btnSearch_Click_1(object sender, EventArgs e) {
            try {
                XmlRpcClient client = new XmlRpcClient();
                client.Url = txtUrl.Text;
                client.Path = "/xmlrpc/2/common";
                string db = txtDB.Text, user = txtUser.Text, pass = txtPass.Text;

                // LOGIN

                XmlRpcRequest requestLogin = new XmlRpcRequest("authenticate");
                requestLogin.AddParams(db, user, pass, XmlRpcParameter.EmptyStruct());

                XmlRpcResponse responseLogin = client.Execute(requestLogin);

                if (responseLogin.IsFault()) {
                    MessageBox.Show(responseLogin.GetFaultString(), "Error");
                    return;
                }

                // SEARCH

                client.Path = "/xmlrpc/2/object";

                XmlRpcRequest requestSearch = new XmlRpcRequest("execute_kw");
                requestSearch.AddParams(db, responseLogin.GetInt(), pass, "res.partner", "search_read",
                    XmlRpcParameter.AsArray(
                        XmlRpcParameter.AsArray(
                            XmlRpcParameter.AsArray("name", "ilike", txtNameSearch.Text)
                        )
                    ),
                    XmlRpcParameter.AsStruct(
                        XmlRpcParameter.AsMember("fields", XmlRpcParameter.AsArray("name", "email"))
                    )
                );

                XmlRpcResponse responseSearch = client.Execute(requestSearch);

                if (responseSearch.IsFault()) {
                    MessageBox.Show(responseSearch.GetFaultString(), "Error");
                    return;
                } else {
                    List<object> listResult = responseSearch.GetArray();
                    listSearch.Items.Clear();
                    int i = 1;
                    foreach (object temp in listResult) {
                        Dictionary<string, object> record = (Dictionary<string, object>)temp;
                        ListViewItem item = new ListViewItem("" + i);
                        item.SubItems.Add(record["name"].ToString());
                        item.SubItems.Add(record["email"].ToString());
                        listSearch.Items.Add(item);
                        i++;
                    }
                }

            } catch (Exception ex) {
                MessageBox.Show(ex.Message, "Error");
            }

        }

        private void InitClose(object sender, CancelEventArgs e) {
            this.Close();
        }

    }
}