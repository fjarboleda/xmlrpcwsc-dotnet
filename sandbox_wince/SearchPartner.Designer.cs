namespace sandbox_wince {
    partial class SearchPartner {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.MainMenu mainMenu1;

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
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.lblUrl = new System.Windows.Forms.Label();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.lblDB = new System.Windows.Forms.Label();
            this.txtDB = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.lblPass = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabCreate = new System.Windows.Forms.TabPage();
            this.btnSearchLogo = new System.Windows.Forms.Button();
            this.txtLogoCreate = new System.Windows.Forms.TextBox();
            this.txtNameCreate = new System.Windows.Forms.TextBox();
            this.lblLogoCreate = new System.Windows.Forms.Label();
            this.lblNameCreate = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.tabSearch = new System.Windows.Forms.TabPage();
            this.listSearch = new System.Windows.Forms.ListView();
            this.chName = new System.Windows.Forms.ColumnHeader();
            this.chEmail = new System.Windows.Forms.ColumnHeader();
            this.txtNameSearch = new System.Windows.Forms.TextBox();
            this.lblNameSearch = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtEmailCreate = new System.Windows.Forms.TextBox();
            this.lblEmailCreate = new System.Windows.Forms.Label();
            this.chNumber = new System.Windows.Forms.ColumnHeader();
            this.tabControl1.SuspendLayout();
            this.tabCreate.SuspendLayout();
            this.tabSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblUrl
            // 
            this.lblUrl.Location = new System.Drawing.Point(4, 4);
            this.lblUrl.Name = "lblUrl";
            this.lblUrl.Size = new System.Drawing.Size(46, 20);
            this.lblUrl.Text = "url";
            // 
            // txtUrl
            // 
            this.txtUrl.Location = new System.Drawing.Point(68, 2);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(169, 21);
            this.txtUrl.TabIndex = 5;
            this.txtUrl.Text = "http://172.16.2.136:8069";
            // 
            // lblDB
            // 
            this.lblDB.Location = new System.Drawing.Point(4, 28);
            this.lblDB.Name = "lblDB";
            this.lblDB.Size = new System.Drawing.Size(46, 20);
            this.lblDB.Text = "db";
            // 
            // txtDB
            // 
            this.txtDB.Location = new System.Drawing.Point(68, 26);
            this.txtDB.Name = "txtDB";
            this.txtDB.Size = new System.Drawing.Size(169, 21);
            this.txtDB.TabIndex = 7;
            this.txtDB.Text = "odoo";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(68, 53);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(169, 21);
            this.txtUser.TabIndex = 9;
            this.txtUser.Text = "admin";
            // 
            // lblUser
            // 
            this.lblUser.Location = new System.Drawing.Point(4, 55);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(46, 20);
            this.lblUser.Text = "user";
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(68, 80);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(169, 21);
            this.txtPass.TabIndex = 14;
            this.txtPass.Text = "admin";
            // 
            // lblPass
            // 
            this.lblPass.Location = new System.Drawing.Point(4, 82);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(46, 20);
            this.lblPass.Text = "pass";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tabControl1.Controls.Add(this.tabCreate);
            this.tabControl1.Controls.Add(this.tabSearch);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.None;
            this.tabControl1.Location = new System.Drawing.Point(0, 105);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(240, 163);
            this.tabControl1.TabIndex = 16;
            // 
            // tabCreate
            // 
            this.tabCreate.Controls.Add(this.txtEmailCreate);
            this.tabCreate.Controls.Add(this.lblEmailCreate);
            this.tabCreate.Controls.Add(this.btnSearchLogo);
            this.tabCreate.Controls.Add(this.txtLogoCreate);
            this.tabCreate.Controls.Add(this.txtNameCreate);
            this.tabCreate.Controls.Add(this.lblLogoCreate);
            this.tabCreate.Controls.Add(this.lblNameCreate);
            this.tabCreate.Controls.Add(this.btnCreate);
            this.tabCreate.Location = new System.Drawing.Point(0, 0);
            this.tabCreate.Name = "tabCreate";
            this.tabCreate.Size = new System.Drawing.Size(240, 140);
            this.tabCreate.Text = "Create";
            // 
            // btnSearchLogo
            // 
            this.btnSearchLogo.Location = new System.Drawing.Point(216, 57);
            this.btnSearchLogo.Name = "btnSearchLogo";
            this.btnSearchLogo.Size = new System.Drawing.Size(21, 21);
            this.btnSearchLogo.TabIndex = 24;
            this.btnSearchLogo.Text = "...";
            this.btnSearchLogo.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtLogoCreate
            // 
            this.txtLogoCreate.Location = new System.Drawing.Point(63, 57);
            this.txtLogoCreate.Name = "txtLogoCreate";
            this.txtLogoCreate.Size = new System.Drawing.Size(147, 21);
            this.txtLogoCreate.TabIndex = 23;
            // 
            // txtNameCreate
            // 
            this.txtNameCreate.Location = new System.Drawing.Point(63, 7);
            this.txtNameCreate.Name = "txtNameCreate";
            this.txtNameCreate.Size = new System.Drawing.Size(174, 21);
            this.txtNameCreate.TabIndex = 22;
            // 
            // lblLogoCreate
            // 
            this.lblLogoCreate.Location = new System.Drawing.Point(4, 57);
            this.lblLogoCreate.Name = "lblLogoCreate";
            this.lblLogoCreate.Size = new System.Drawing.Size(53, 20);
            this.lblLogoCreate.Text = "Logo";
            // 
            // lblNameCreate
            // 
            this.lblNameCreate.Location = new System.Drawing.Point(4, 7);
            this.lblNameCreate.Name = "lblNameCreate";
            this.lblNameCreate.Size = new System.Drawing.Size(53, 20);
            this.lblNameCreate.Text = "Name";
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(165, 84);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(72, 20);
            this.btnCreate.TabIndex = 21;
            this.btnCreate.Text = "Create";
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // tabSearch
            // 
            this.tabSearch.Controls.Add(this.txtNameSearch);
            this.tabSearch.Controls.Add(this.lblNameSearch);
            this.tabSearch.Controls.Add(this.btnSearch);
            this.tabSearch.Controls.Add(this.listSearch);
            this.tabSearch.Location = new System.Drawing.Point(0, 0);
            this.tabSearch.Name = "tabSearch";
            this.tabSearch.Size = new System.Drawing.Size(240, 140);
            this.tabSearch.Text = "Search";
            // 
            // listSearch
            // 
            this.listSearch.Columns.Add(this.chNumber);
            this.listSearch.Columns.Add(this.chName);
            this.listSearch.Columns.Add(this.chEmail);
            this.listSearch.Location = new System.Drawing.Point(0, 53);
            this.listSearch.Name = "listSearch";
            this.listSearch.Size = new System.Drawing.Size(240, 87);
            this.listSearch.TabIndex = 0;
            this.listSearch.View = System.Windows.Forms.View.Details;
            // 
            // chName
            // 
            this.chName.Text = "Name";
            this.chName.Width = 200;
            // 
            // chEmail
            // 
            this.chEmail.Text = "Email";
            this.chEmail.Width = 200;
            // 
            // txtNameSearch
            // 
            this.txtNameSearch.Location = new System.Drawing.Point(63, 3);
            this.txtNameSearch.Name = "txtNameSearch";
            this.txtNameSearch.Size = new System.Drawing.Size(174, 21);
            this.txtNameSearch.TabIndex = 25;
            // 
            // lblNameSearch
            // 
            this.lblNameSearch.Location = new System.Drawing.Point(4, 4);
            this.lblNameSearch.Name = "lblNameSearch";
            this.lblNameSearch.Size = new System.Drawing.Size(53, 20);
            this.lblNameSearch.Text = "Name";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(165, 27);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(72, 20);
            this.btnSearch.TabIndex = 24;
            this.btnSearch.Text = "Search";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click_1);
            // 
            // txtEmailCreate
            // 
            this.txtEmailCreate.Location = new System.Drawing.Point(63, 32);
            this.txtEmailCreate.Name = "txtEmailCreate";
            this.txtEmailCreate.Size = new System.Drawing.Size(174, 21);
            this.txtEmailCreate.TabIndex = 28;
            // 
            // lblEmailCreate
            // 
            this.lblEmailCreate.Location = new System.Drawing.Point(4, 32);
            this.lblEmailCreate.Name = "lblEmailCreate";
            this.lblEmailCreate.Size = new System.Drawing.Size(53, 20);
            this.lblEmailCreate.Text = "Email";
            // 
            // chNumber
            // 
            this.chNumber.Text = "Nº";
            this.chNumber.Width = 40;
            // 
            // SearchPartner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.txtDB);
            this.Controls.Add(this.lblDB);
            this.Controls.Add(this.txtUrl);
            this.Controls.Add(this.lblUrl);
            this.Menu = this.mainMenu1;
            this.Name = "SearchPartner";
            this.Text = "Search Partner";
            this.Closing += new System.ComponentModel.CancelEventHandler(this.InitClose);
            this.tabControl1.ResumeLayout(false);
            this.tabCreate.ResumeLayout(false);
            this.tabSearch.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblUrl;
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.Label lblDB;
        private System.Windows.Forms.TextBox txtDB;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabCreate;
        private System.Windows.Forms.TabPage tabSearch;
        private System.Windows.Forms.Button btnSearchLogo;
        private System.Windows.Forms.TextBox txtLogoCreate;
        private System.Windows.Forms.TextBox txtNameCreate;
        private System.Windows.Forms.Label lblLogoCreate;
        private System.Windows.Forms.Label lblNameCreate;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.ListView listSearch;
        private System.Windows.Forms.ColumnHeader chName;
        private System.Windows.Forms.ColumnHeader chEmail;
        private System.Windows.Forms.TextBox txtNameSearch;
        private System.Windows.Forms.Label lblNameSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtEmailCreate;
        private System.Windows.Forms.Label lblEmailCreate;
        private System.Windows.Forms.ColumnHeader chNumber;
    }
}

