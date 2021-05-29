
namespace General_Manager.Form
{
    partial class SignInAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignInAccount));
            this.Label_fname = new DevExpress.XtraEditors.LabelControl();
            this.Label_bday = new DevExpress.XtraEditors.LabelControl();
            this.Label_cmnd = new DevExpress.XtraEditors.LabelControl();
            this.Label_Username = new DevExpress.XtraEditors.LabelControl();
            this.PictureUser = new DevExpress.XtraEditors.PictureEdit();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.XtraPage_Account = new DevExpress.XtraTab.XtraTabPage();
            this.Repass_Textbox = new System.Windows.Forms.TextBox();
            this.Password_Textbox = new System.Windows.Forms.TextBox();
            this.Username_Textbox = new System.Windows.Forms.TextBox();
            this.Label_repass = new DevExpress.XtraEditors.LabelControl();
            this.Label_pass = new DevExpress.XtraEditors.LabelControl();
            this.Label_infor = new DevExpress.XtraEditors.LabelControl();
            this.Fullname_Textbox = new System.Windows.Forms.TextBox();
            this.Cmnd_Textbox = new System.Windows.Forms.TextBox();
            this.Birthday_edit = new DevExpress.XtraEditors.DateEdit();
            this.SignIn_btn = new DevExpress.XtraEditors.SimpleButton();
            this.Exit_btn = new DevExpress.XtraEditors.SimpleButton();
            this.Reset_btn = new DevExpress.XtraEditors.SimpleButton();
            this.HyperlinkLabelControl = new DevExpress.XtraEditors.HyperlinkLabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.PictureUser.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.XtraPage_Account.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Birthday_edit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Birthday_edit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // Label_fname
            // 
            this.Label_fname.Location = new System.Drawing.Point(291, 60);
            this.Label_fname.Name = "Label_fname";
            this.Label_fname.Size = new System.Drawing.Size(64, 17);
            this.Label_fname.TabIndex = 0;
            this.Label_fname.Text = "Full Name";
            // 
            // Label_bday
            // 
            this.Label_bday.Location = new System.Drawing.Point(289, 105);
            this.Label_bday.Name = "Label_bday";
            this.Label_bday.Size = new System.Drawing.Size(63, 17);
            this.Label_bday.TabIndex = 1;
            this.Label_bday.Text = "Birth Date";
            // 
            // Label_cmnd
            // 
            this.Label_cmnd.Location = new System.Drawing.Point(289, 155);
            this.Label_cmnd.Name = "Label_cmnd";
            this.Label_cmnd.Size = new System.Drawing.Size(42, 17);
            this.Label_cmnd.TabIndex = 2;
            this.Label_cmnd.Text = "CMND";
            // 
            // Label_Username
            // 
            this.Label_Username.Location = new System.Drawing.Point(23, 25);
            this.Label_Username.Name = "Label_Username";
            this.Label_Username.Size = new System.Drawing.Size(63, 17);
            this.Label_Username.TabIndex = 3;
            this.Label_Username.Text = "Username";
            // 
            // PictureUser
            // 
            this.PictureUser.EditValue = ((object)(resources.GetObject("PictureUser.EditValue")));
            this.PictureUser.Location = new System.Drawing.Point(12, 60);
            this.PictureUser.Name = "PictureUser";
            this.PictureUser.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.PictureUser.Size = new System.Drawing.Size(253, 324);
            this.PictureUser.TabIndex = 5;
            this.PictureUser.Click += new System.EventHandler(this.PictureUser_Click);
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Location = new System.Drawing.Point(289, 211);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.XtraPage_Account;
            this.xtraTabControl1.Size = new System.Drawing.Size(475, 173);
            this.xtraTabControl1.TabIndex = 6;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.XtraPage_Account});
            // 
            // XtraPage_Account
            // 
            this.XtraPage_Account.Controls.Add(this.Repass_Textbox);
            this.XtraPage_Account.Controls.Add(this.Password_Textbox);
            this.XtraPage_Account.Controls.Add(this.Username_Textbox);
            this.XtraPage_Account.Controls.Add(this.Label_repass);
            this.XtraPage_Account.Controls.Add(this.Label_pass);
            this.XtraPage_Account.Controls.Add(this.Label_Username);
            this.XtraPage_Account.Name = "XtraPage_Account";
            this.XtraPage_Account.Size = new System.Drawing.Size(471, 144);
            this.XtraPage_Account.Text = "Account";
            // 
            // Repass_Textbox
            // 
            this.Repass_Textbox.Location = new System.Drawing.Point(124, 102);
            this.Repass_Textbox.Name = "Repass_Textbox";
            this.Repass_Textbox.Size = new System.Drawing.Size(330, 23);
            this.Repass_Textbox.TabIndex = 11;
            // 
            // Password_Textbox
            // 
            this.Password_Textbox.Location = new System.Drawing.Point(124, 62);
            this.Password_Textbox.Name = "Password_Textbox";
            this.Password_Textbox.Size = new System.Drawing.Size(330, 23);
            this.Password_Textbox.TabIndex = 10;
            // 
            // Username_Textbox
            // 
            this.Username_Textbox.Location = new System.Drawing.Point(124, 22);
            this.Username_Textbox.Name = "Username_Textbox";
            this.Username_Textbox.Size = new System.Drawing.Size(330, 23);
            this.Username_Textbox.TabIndex = 9;
            // 
            // Label_repass
            // 
            this.Label_repass.Location = new System.Drawing.Point(23, 102);
            this.Label_repass.Name = "Label_repass";
            this.Label_repass.Size = new System.Drawing.Size(82, 17);
            this.Label_repass.TabIndex = 6;
            this.Label_repass.Text = "Re-password";
            // 
            // Label_pass
            // 
            this.Label_pass.Location = new System.Drawing.Point(23, 62);
            this.Label_pass.Name = "Label_pass";
            this.Label_pass.Size = new System.Drawing.Size(61, 17);
            this.Label_pass.TabIndex = 5;
            this.Label_pass.Text = "Password";
            // 
            // Label_infor
            // 
            this.Label_infor.Appearance.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_infor.Appearance.ForeColor = System.Drawing.Color.DodgerBlue;
            this.Label_infor.Appearance.Options.UseFont = true;
            this.Label_infor.Appearance.Options.UseForeColor = true;
            this.Label_infor.Location = new System.Drawing.Point(84, 12);
            this.Label_infor.Name = "Label_infor";
            this.Label_infor.Size = new System.Drawing.Size(92, 19);
            this.Label_infor.TabIndex = 7;
            this.Label_infor.Text = "Information";
            // 
            // Fullname_Textbox
            // 
            this.Fullname_Textbox.Location = new System.Drawing.Point(391, 54);
            this.Fullname_Textbox.Name = "Fullname_Textbox";
            this.Fullname_Textbox.Size = new System.Drawing.Size(371, 23);
            this.Fullname_Textbox.TabIndex = 8;
            // 
            // Cmnd_Textbox
            // 
            this.Cmnd_Textbox.Location = new System.Drawing.Point(391, 155);
            this.Cmnd_Textbox.Name = "Cmnd_Textbox";
            this.Cmnd_Textbox.Size = new System.Drawing.Size(371, 23);
            this.Cmnd_Textbox.TabIndex = 9;
            // 
            // Birthday_edit
            // 
            this.Birthday_edit.EditValue = null;
            this.Birthday_edit.Location = new System.Drawing.Point(391, 105);
            this.Birthday_edit.Name = "Birthday_edit";
            this.Birthday_edit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.Birthday_edit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.Birthday_edit.Size = new System.Drawing.Size(163, 24);
            this.Birthday_edit.TabIndex = 10;
            // 
            // SignIn_btn
            // 
            this.SignIn_btn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("SignIn_btn.ImageOptions.Image")));
            this.SignIn_btn.Location = new System.Drawing.Point(291, 408);
            this.SignIn_btn.Name = "SignIn_btn";
            this.SignIn_btn.Size = new System.Drawing.Size(105, 41);
            this.SignIn_btn.TabIndex = 11;
            this.SignIn_btn.Text = "Sign in";
            this.SignIn_btn.Click += new System.EventHandler(this.SignIn_btn_Click);
            // 
            // Exit_btn
            // 
            this.Exit_btn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Exit_btn.ImageOptions.Image")));
            this.Exit_btn.Location = new System.Drawing.Point(484, 408);
            this.Exit_btn.Name = "Exit_btn";
            this.Exit_btn.Size = new System.Drawing.Size(111, 41);
            this.Exit_btn.TabIndex = 12;
            this.Exit_btn.Text = "Exit";
            // 
            // Reset_btn
            // 
            this.Reset_btn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Reset_btn.ImageOptions.Image")));
            this.Reset_btn.Location = new System.Drawing.Point(655, 408);
            this.Reset_btn.Name = "Reset_btn";
            this.Reset_btn.Size = new System.Drawing.Size(107, 41);
            this.Reset_btn.TabIndex = 13;
            this.Reset_btn.Text = "Reset";
            // 
            // HyperlinkLabelControl
            // 
            this.HyperlinkLabelControl.Location = new System.Drawing.Point(28, 432);
            this.HyperlinkLabelControl.Name = "HyperlinkLabelControl";
            this.HyperlinkLabelControl.Size = new System.Drawing.Size(205, 17);
            this.HyperlinkLabelControl.TabIndex = 14;
            this.HyperlinkLabelControl.Text = "I have a account <login now?>";
            // 
            // SignInAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 475);
            this.Controls.Add(this.HyperlinkLabelControl);
            this.Controls.Add(this.Reset_btn);
            this.Controls.Add(this.Exit_btn);
            this.Controls.Add(this.SignIn_btn);
            this.Controls.Add(this.Birthday_edit);
            this.Controls.Add(this.Cmnd_Textbox);
            this.Controls.Add(this.Fullname_Textbox);
            this.Controls.Add(this.Label_infor);
            this.Controls.Add(this.xtraTabControl1);
            this.Controls.Add(this.PictureUser);
            this.Controls.Add(this.Label_cmnd);
            this.Controls.Add(this.Label_bday);
            this.Controls.Add(this.Label_fname);
            this.Name = "SignInAccount";
            this.Text = "LoginAccount";
            ((System.ComponentModel.ISupportInitialize)(this.PictureUser.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.XtraPage_Account.ResumeLayout(false);
            this.XtraPage_Account.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Birthday_edit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Birthday_edit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl Label_fname;
        private DevExpress.XtraEditors.LabelControl Label_bday;
        private DevExpress.XtraEditors.LabelControl Label_cmnd;
        private DevExpress.XtraEditors.LabelControl Label_Username;
        private DevExpress.XtraEditors.PictureEdit PictureUser;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage XtraPage_Account;
        private DevExpress.XtraEditors.LabelControl Label_infor;
        private DevExpress.XtraEditors.LabelControl Label_pass;
        private System.Windows.Forms.TextBox Repass_Textbox;
        private System.Windows.Forms.TextBox Password_Textbox;
        private System.Windows.Forms.TextBox Username_Textbox;
        private DevExpress.XtraEditors.LabelControl Label_repass;
        private System.Windows.Forms.TextBox Fullname_Textbox;
        private System.Windows.Forms.TextBox Cmnd_Textbox;
        private DevExpress.XtraEditors.DateEdit Birthday_edit;
        private DevExpress.XtraEditors.SimpleButton SignIn_btn;
        private DevExpress.XtraEditors.SimpleButton Exit_btn;
        private DevExpress.XtraEditors.SimpleButton Reset_btn;
        private DevExpress.XtraEditors.HyperlinkLabelControl HyperlinkLabelControl;
    }
}