
namespace General_Manager.Form
{
    partial class Login_Account
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
            this.User_lb = new DevExpress.XtraEditors.LabelControl();
            this.Pass_lb = new DevExpress.XtraEditors.LabelControl();
            this.Username_tb = new DevExpress.XtraEditors.TextEdit();
            this.Password_tb = new DevExpress.XtraEditors.TextEdit();
            this.Exit_bt = new DevExpress.XtraEditors.SimpleButton();
            this.Login_bt = new DevExpress.XtraEditors.SimpleButton();
            this.SignIn_bt = new DevExpress.XtraEditors.SimpleButton();
            this.Picture_Account = new DevExpress.XtraEditors.PictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.Username_tb.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Password_tb.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Picture_Account.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // User_lb
            // 
            this.User_lb.Location = new System.Drawing.Point(268, 51);
            this.User_lb.Name = "User_lb";
            this.User_lb.Size = new System.Drawing.Size(52, 13);
            this.User_lb.TabIndex = 0;
            this.User_lb.Text = "Username:";
            // 
            // Pass_lb
            // 
            this.Pass_lb.Location = new System.Drawing.Point(268, 128);
            this.Pass_lb.Name = "Pass_lb";
            this.Pass_lb.Size = new System.Drawing.Size(50, 13);
            this.Pass_lb.TabIndex = 1;
            this.Pass_lb.Text = "Password:";
            // 
            // Username_tb
            // 
            this.Username_tb.Location = new System.Drawing.Point(366, 48);
            this.Username_tb.Name = "Username_tb";
            this.Username_tb.Size = new System.Drawing.Size(186, 20);
            this.Username_tb.TabIndex = 2;
            // 
            // Password_tb
            // 
            this.Password_tb.Location = new System.Drawing.Point(366, 125);
            this.Password_tb.Name = "Password_tb";
            this.Password_tb.Size = new System.Drawing.Size(186, 20);
            this.Password_tb.TabIndex = 3;
            // 
            // Exit_bt
            // 
            this.Exit_bt.Location = new System.Drawing.Point(366, 233);
            this.Exit_bt.Name = "Exit_bt";
            this.Exit_bt.Size = new System.Drawing.Size(75, 23);
            this.Exit_bt.TabIndex = 4;
            this.Exit_bt.Text = "Exit";
            // 
            // Login_bt
            // 
            this.Login_bt.Location = new System.Drawing.Point(477, 233);
            this.Login_bt.Name = "Login_bt";
            this.Login_bt.Size = new System.Drawing.Size(75, 23);
            this.Login_bt.TabIndex = 5;
            this.Login_bt.Text = "Login";
            this.Login_bt.Click += new System.EventHandler(this.Login_bt_Click);
            // 
            // SignIn_bt
            // 
            this.SignIn_bt.Location = new System.Drawing.Point(366, 187);
            this.SignIn_bt.Name = "SignIn_bt";
            this.SignIn_bt.Size = new System.Drawing.Size(186, 23);
            this.SignIn_bt.TabIndex = 6;
            this.SignIn_bt.Text = "Sign In new Account";
            this.SignIn_bt.Click += new System.EventHandler(this.SignIn_bt_Click);
            // 
            // Picture_Account
            // 
            this.Picture_Account.Location = new System.Drawing.Point(12, 12);
            this.Picture_Account.Name = "Picture_Account";
            this.Picture_Account.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.Picture_Account.Size = new System.Drawing.Size(201, 273);
            this.Picture_Account.TabIndex = 7;
            // 
            // Login_Account
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 330);
            this.Controls.Add(this.Picture_Account);
            this.Controls.Add(this.SignIn_bt);
            this.Controls.Add(this.Login_bt);
            this.Controls.Add(this.Exit_bt);
            this.Controls.Add(this.Password_tb);
            this.Controls.Add(this.Username_tb);
            this.Controls.Add(this.Pass_lb);
            this.Controls.Add(this.User_lb);
            this.Name = "Login_Account";
            this.Text = "Login Account";
            ((System.ComponentModel.ISupportInitialize)(this.Username_tb.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Password_tb.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Picture_Account.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl User_lb;
        private DevExpress.XtraEditors.LabelControl Pass_lb;
        private DevExpress.XtraEditors.TextEdit Username_tb;
        private DevExpress.XtraEditors.TextEdit Password_tb;
        private DevExpress.XtraEditors.SimpleButton Exit_bt;
        private DevExpress.XtraEditors.SimpleButton Login_bt;
        private DevExpress.XtraEditors.SimpleButton SignIn_bt;
        private DevExpress.XtraEditors.PictureEdit Picture_Account;
    }
}