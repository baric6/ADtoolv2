namespace ADtoolv2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.userName = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.domain = new System.Windows.Forms.TextBox();
            this.btnADconnect = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cboxusergroups = new System.Windows.Forms.CheckBox();
            this.txtboxusergroups = new System.Windows.Forms.RichTextBox();
            this.cboxlastlogontimestamp = new System.Windows.Forms.CheckBox();
            this.cboxlastlogon = new System.Windows.Forms.CheckBox();
            this.cboxlastlogoff = new System.Windows.Forms.CheckBox();
            this.cboxpager = new System.Windows.Forms.CheckBox();
            this.cboxiphone = new System.Windows.Forms.CheckBox();
            this.cboxphone = new System.Windows.Forms.CheckBox();
            this.cboxdisplayname = new System.Windows.Forms.CheckBox();
            this.cboxdisc = new System.Windows.Forms.CheckBox();
            this.cboxemail = new System.Windows.Forms.CheckBox();
            this.cboxsamaccount = new System.Windows.Forms.CheckBox();
            this.userInfo = new System.Windows.Forms.RichTextBox();
            this.btnUserSearch = new System.Windows.Forms.Button();
            this.txtUserSearch = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.debugView = new System.Windows.Forms.RichTextBox();
            this.cboxAccEnabled = new System.Windows.Forms.CheckBox();
            this.cboxoffice = new System.Windows.Forms.CheckBox();
            this.cboxcompany = new System.Windows.Forms.CheckBox();
            this.cboxlogonCount = new System.Windows.Forms.CheckBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "userName";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 29);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 51);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "domain";
            // 
            // userName
            // 
            this.userName.Location = new System.Drawing.Point(66, 5);
            this.userName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(126, 20);
            this.userName.TabIndex = 3;
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(66, 28);
            this.password.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(126, 20);
            this.password.TabIndex = 4;
            // 
            // domain
            // 
            this.domain.Location = new System.Drawing.Point(66, 49);
            this.domain.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.domain.Name = "domain";
            this.domain.Size = new System.Drawing.Size(126, 20);
            this.domain.TabIndex = 5;
            // 
            // btnADconnect
            // 
            this.btnADconnect.Location = new System.Drawing.Point(206, 46);
            this.btnADconnect.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnADconnect.Name = "btnADconnect";
            this.btnADconnect.Size = new System.Drawing.Size(56, 19);
            this.btnADconnect.TabIndex = 6;
            this.btnADconnect.Text = "connect";
            this.btnADconnect.UseVisualStyleBackColor = true;
            this.btnADconnect.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(2, 88);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(722, 339);
            this.tabControl1.TabIndex = 8;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.cboxlogonCount);
            this.tabPage1.Controls.Add(this.cboxcompany);
            this.tabPage1.Controls.Add(this.cboxoffice);
            this.tabPage1.Controls.Add(this.cboxAccEnabled);
            this.tabPage1.Controls.Add(this.cboxusergroups);
            this.tabPage1.Controls.Add(this.txtboxusergroups);
            this.tabPage1.Controls.Add(this.cboxlastlogontimestamp);
            this.tabPage1.Controls.Add(this.cboxlastlogon);
            this.tabPage1.Controls.Add(this.cboxlastlogoff);
            this.tabPage1.Controls.Add(this.cboxpager);
            this.tabPage1.Controls.Add(this.cboxiphone);
            this.tabPage1.Controls.Add(this.cboxphone);
            this.tabPage1.Controls.Add(this.cboxdisplayname);
            this.tabPage1.Controls.Add(this.cboxdisc);
            this.tabPage1.Controls.Add(this.cboxemail);
            this.tabPage1.Controls.Add(this.cboxsamaccount);
            this.tabPage1.Controls.Add(this.userInfo);
            this.tabPage1.Controls.Add(this.btnUserSearch);
            this.tabPage1.Controls.Add(this.txtUserSearch);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Size = new System.Drawing.Size(714, 313);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // cboxusergroups
            // 
            this.cboxusergroups.AutoSize = true;
            this.cboxusergroups.Checked = true;
            this.cboxusergroups.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cboxusergroups.Location = new System.Drawing.Point(347, 193);
            this.cboxusergroups.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboxusergroups.Name = "cboxusergroups";
            this.cboxusergroups.Size = new System.Drawing.Size(81, 17);
            this.cboxusergroups.TabIndex = 15;
            this.cboxusergroups.Text = "user groups";
            this.cboxusergroups.UseVisualStyleBackColor = true;
            // 
            // txtboxusergroups
            // 
            this.txtboxusergroups.Location = new System.Drawing.Point(346, 214);
            this.txtboxusergroups.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtboxusergroups.Name = "txtboxusergroups";
            this.txtboxusergroups.Size = new System.Drawing.Size(266, 89);
            this.txtboxusergroups.TabIndex = 14;
            this.txtboxusergroups.Text = "";
            // 
            // cboxlastlogontimestamp
            // 
            this.cboxlastlogontimestamp.AutoSize = true;
            this.cboxlastlogontimestamp.Location = new System.Drawing.Point(559, 47);
            this.cboxlastlogontimestamp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboxlastlogontimestamp.Name = "cboxlastlogontimestamp";
            this.cboxlastlogontimestamp.Size = new System.Drawing.Size(121, 17);
            this.cboxlastlogontimestamp.TabIndex = 13;
            this.cboxlastlogontimestamp.Text = "last logon timestamp";
            this.cboxlastlogontimestamp.UseVisualStyleBackColor = true;
            // 
            // cboxlastlogon
            // 
            this.cboxlastlogon.AutoSize = true;
            this.cboxlastlogon.Location = new System.Drawing.Point(559, 26);
            this.cboxlastlogon.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboxlastlogon.Name = "cboxlastlogon";
            this.cboxlastlogon.Size = new System.Drawing.Size(71, 17);
            this.cboxlastlogon.TabIndex = 12;
            this.cboxlastlogon.Text = "last logon";
            this.cboxlastlogon.UseVisualStyleBackColor = true;
            // 
            // cboxlastlogoff
            // 
            this.cboxlastlogoff.AutoSize = true;
            this.cboxlastlogoff.Location = new System.Drawing.Point(559, 4);
            this.cboxlastlogoff.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboxlastlogoff.Name = "cboxlastlogoff";
            this.cboxlastlogoff.Size = new System.Drawing.Size(78, 17);
            this.cboxlastlogoff.TabIndex = 11;
            this.cboxlastlogoff.Text = "last Log off";
            this.cboxlastlogoff.UseVisualStyleBackColor = true;
            // 
            // cboxpager
            // 
            this.cboxpager.AutoSize = true;
            this.cboxpager.Location = new System.Drawing.Point(456, 47);
            this.cboxpager.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboxpager.Name = "cboxpager";
            this.cboxpager.Size = new System.Drawing.Size(53, 17);
            this.cboxpager.TabIndex = 10;
            this.cboxpager.Text = "pager";
            this.cboxpager.UseVisualStyleBackColor = true;
            // 
            // cboxiphone
            // 
            this.cboxiphone.AutoSize = true;
            this.cboxiphone.Location = new System.Drawing.Point(456, 26);
            this.cboxiphone.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboxiphone.Name = "cboxiphone";
            this.cboxiphone.Size = new System.Drawing.Size(67, 17);
            this.cboxiphone.TabIndex = 9;
            this.cboxiphone.Text = "ip phone";
            this.cboxiphone.UseVisualStyleBackColor = true;
            // 
            // cboxphone
            // 
            this.cboxphone.AutoSize = true;
            this.cboxphone.Location = new System.Drawing.Point(456, 5);
            this.cboxphone.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboxphone.Name = "cboxphone";
            this.cboxphone.Size = new System.Drawing.Size(89, 17);
            this.cboxphone.TabIndex = 8;
            this.cboxphone.Text = "mobile phone";
            this.cboxphone.UseVisualStyleBackColor = true;
            // 
            // cboxdisplayname
            // 
            this.cboxdisplayname.AutoSize = true;
            this.cboxdisplayname.Location = new System.Drawing.Point(346, 26);
            this.cboxdisplayname.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboxdisplayname.Name = "cboxdisplayname";
            this.cboxdisplayname.Size = new System.Drawing.Size(87, 17);
            this.cboxdisplayname.TabIndex = 7;
            this.cboxdisplayname.Text = "display name";
            this.cboxdisplayname.UseVisualStyleBackColor = true;
            // 
            // cboxdisc
            // 
            this.cboxdisc.AutoSize = true;
            this.cboxdisc.Location = new System.Drawing.Point(346, 68);
            this.cboxdisc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboxdisc.Name = "cboxdisc";
            this.cboxdisc.Size = new System.Drawing.Size(77, 17);
            this.cboxdisc.TabIndex = 6;
            this.cboxdisc.Text = "description";
            this.cboxdisc.UseVisualStyleBackColor = true;
            // 
            // cboxemail
            // 
            this.cboxemail.AutoSize = true;
            this.cboxemail.Location = new System.Drawing.Point(346, 47);
            this.cboxemail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboxemail.Name = "cboxemail";
            this.cboxemail.Size = new System.Drawing.Size(50, 17);
            this.cboxemail.TabIndex = 5;
            this.cboxemail.Text = "email";
            this.cboxemail.UseVisualStyleBackColor = true;
            // 
            // cboxsamaccount
            // 
            this.cboxsamaccount.AutoSize = true;
            this.cboxsamaccount.Checked = true;
            this.cboxsamaccount.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cboxsamaccount.Location = new System.Drawing.Point(346, 5);
            this.cboxsamaccount.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboxsamaccount.Name = "cboxsamaccount";
            this.cboxsamaccount.Size = new System.Drawing.Size(87, 17);
            this.cboxsamaccount.TabIndex = 4;
            this.cboxsamaccount.Text = "sam account";
            this.cboxsamaccount.UseVisualStyleBackColor = true;
            // 
            // userInfo
            // 
            this.userInfo.Location = new System.Drawing.Point(16, 32);
            this.userInfo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.userInfo.Name = "userInfo";
            this.userInfo.Size = new System.Drawing.Size(326, 271);
            this.userInfo.TabIndex = 3;
            this.userInfo.Text = "";
            // 
            // btnUserSearch
            // 
            this.btnUserSearch.Location = new System.Drawing.Point(246, 8);
            this.btnUserSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnUserSearch.Name = "btnUserSearch";
            this.btnUserSearch.Size = new System.Drawing.Size(78, 19);
            this.btnUserSearch.TabIndex = 2;
            this.btnUserSearch.Text = "search user";
            this.btnUserSearch.UseVisualStyleBackColor = true;
            this.btnUserSearch.Click += new System.EventHandler(this.btnUserSearch_Click);
            // 
            // txtUserSearch
            // 
            this.txtUserSearch.Location = new System.Drawing.Point(68, 8);
            this.txtUserSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtUserSearch.Name = "txtUserSearch";
            this.txtUserSearch.Size = new System.Drawing.Size(174, 20);
            this.txtUserSearch.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 8);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "UserSearch";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage2.Size = new System.Drawing.Size(714, 313);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // debugView
            // 
            this.debugView.Location = new System.Drawing.Point(282, 5);
            this.debugView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.debugView.Name = "debugView";
            this.debugView.ReadOnly = true;
            this.debugView.Size = new System.Drawing.Size(440, 79);
            this.debugView.TabIndex = 11;
            this.debugView.Text = "";
            // 
            // cboxAccEnabled
            // 
            this.cboxAccEnabled.AutoSize = true;
            this.cboxAccEnabled.Location = new System.Drawing.Point(559, 69);
            this.cboxAccEnabled.Name = "cboxAccEnabled";
            this.cboxAccEnabled.Size = new System.Drawing.Size(106, 17);
            this.cboxAccEnabled.TabIndex = 16;
            this.cboxAccEnabled.Text = "account enabled";
            this.cboxAccEnabled.UseVisualStyleBackColor = true;
            // 
            // cboxoffice
            // 
            this.cboxoffice.AutoSize = true;
            this.cboxoffice.Location = new System.Drawing.Point(456, 69);
            this.cboxoffice.Name = "cboxoffice";
            this.cboxoffice.Size = new System.Drawing.Size(52, 17);
            this.cboxoffice.TabIndex = 17;
            this.cboxoffice.Text = "office";
            this.cboxoffice.UseVisualStyleBackColor = true;
            // 
            // cboxcompany
            // 
            this.cboxcompany.AutoSize = true;
            this.cboxcompany.Location = new System.Drawing.Point(346, 90);
            this.cboxcompany.Name = "cboxcompany";
            this.cboxcompany.Size = new System.Drawing.Size(69, 17);
            this.cboxcompany.TabIndex = 18;
            this.cboxcompany.Text = "company";
            this.cboxcompany.UseVisualStyleBackColor = true;
            // 
            // cboxlogonCount
            // 
            this.cboxlogonCount.AutoSize = true;
            this.cboxlogonCount.Location = new System.Drawing.Point(559, 92);
            this.cboxlogonCount.Name = "cboxlogonCount";
            this.cboxlogonCount.Size = new System.Drawing.Size(82, 17);
            this.cboxlogonCount.TabIndex = 19;
            this.cboxlogonCount.Text = "logon count";
            this.cboxlogonCount.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 436);
            this.Controls.Add(this.debugView);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnADconnect);
            this.Controls.Add(this.domain);
            this.Controls.Add(this.password);
            this.Controls.Add(this.userName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox userName;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox domain;
        private System.Windows.Forms.Button btnADconnect;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.RichTextBox debugView;
        private System.Windows.Forms.RichTextBox userInfo;
        private System.Windows.Forms.Button btnUserSearch;
        private System.Windows.Forms.TextBox txtUserSearch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox cboxlastlogontimestamp;
        private System.Windows.Forms.CheckBox cboxlastlogon;
        private System.Windows.Forms.CheckBox cboxlastlogoff;
        private System.Windows.Forms.CheckBox cboxpager;
        private System.Windows.Forms.CheckBox cboxiphone;
        private System.Windows.Forms.CheckBox cboxphone;
        private System.Windows.Forms.CheckBox cboxdisplayname;
        private System.Windows.Forms.CheckBox cboxdisc;
        private System.Windows.Forms.CheckBox cboxemail;
        private System.Windows.Forms.CheckBox cboxsamaccount;
        private System.Windows.Forms.CheckBox cboxusergroups;
        private System.Windows.Forms.RichTextBox txtboxusergroups;
        private System.Windows.Forms.CheckBox cboxAccEnabled;
        private System.Windows.Forms.CheckBox cboxoffice;
        private System.Windows.Forms.CheckBox cboxcompany;
        private System.Windows.Forms.CheckBox cboxlogonCount;
    }
}

