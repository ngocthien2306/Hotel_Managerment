
namespace General_Manager.Form
{
    partial class Signin_Account
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Signin_Account));
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.Canncel_bt = new DevExpress.XtraEditors.SimpleButton();
            this.SignIn_bt = new DevExpress.XtraEditors.SimpleButton();
            this.Repass_tb = new DevExpress.XtraEditors.TextEdit();
            this.Password_tb = new DevExpress.XtraEditors.TextEdit();
            this.Username_tb = new DevExpress.XtraEditors.TextEdit();
            this.RePass_lb = new DevExpress.XtraEditors.LabelControl();
            this.Pass_lb = new DevExpress.XtraEditors.LabelControl();
            this.User_lb = new DevExpress.XtraEditors.LabelControl();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Repass_tb.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Password_tb.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Username_tb.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.pictureEdit1);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.Canncel_bt);
            this.splitContainerControl1.Panel2.Controls.Add(this.SignIn_bt);
            this.splitContainerControl1.Panel2.Controls.Add(this.Repass_tb);
            this.splitContainerControl1.Panel2.Controls.Add(this.Password_tb);
            this.splitContainerControl1.Panel2.Controls.Add(this.Username_tb);
            this.splitContainerControl1.Panel2.Controls.Add(this.RePass_lb);
            this.splitContainerControl1.Panel2.Controls.Add(this.Pass_lb);
            this.splitContainerControl1.Panel2.Controls.Add(this.User_lb);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(701, 347);
            this.splitContainerControl1.SplitterPosition = 246;
            this.splitContainerControl1.TabIndex = 0;
            // 
            // Canncel_bt
            // 
            this.Canncel_bt.Appearance.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Canncel_bt.Appearance.Options.UseFont = true;
            this.Canncel_bt.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("Canncel_bt.ImageOptions.SvgImage")));
            this.Canncel_bt.Location = new System.Drawing.Point(329, 252);
            this.Canncel_bt.Name = "Canncel_bt";
            this.Canncel_bt.Size = new System.Drawing.Size(84, 40);
            this.Canncel_bt.TabIndex = 16;
            this.Canncel_bt.Text = "Cancel";
            // 
            // SignIn_bt
            // 
            this.SignIn_bt.Appearance.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignIn_bt.Appearance.Options.UseFont = true;
            this.SignIn_bt.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("SignIn_bt.ImageOptions.Image")));
            this.SignIn_bt.Location = new System.Drawing.Point(196, 252);
            this.SignIn_bt.Name = "SignIn_bt";
            this.SignIn_bt.Size = new System.Drawing.Size(84, 40);
            this.SignIn_bt.TabIndex = 15;
            this.SignIn_bt.Text = "Sign In";
            // 
            // Repass_tb
            // 
            this.Repass_tb.Location = new System.Drawing.Point(196, 193);
            this.Repass_tb.Name = "Repass_tb";
            this.Repass_tb.Properties.Appearance.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Repass_tb.Properties.Appearance.ForeColor = System.Drawing.Color.DodgerBlue;
            this.Repass_tb.Properties.Appearance.Options.UseFont = true;
            this.Repass_tb.Properties.Appearance.Options.UseForeColor = true;
            this.Repass_tb.Size = new System.Drawing.Size(217, 32);
            this.Repass_tb.TabIndex = 14;
            // 
            // Password_tb
            // 
            this.Password_tb.Location = new System.Drawing.Point(196, 116);
            this.Password_tb.Name = "Password_tb";
            this.Password_tb.Properties.Appearance.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password_tb.Properties.Appearance.ForeColor = System.Drawing.Color.DodgerBlue;
            this.Password_tb.Properties.Appearance.Options.UseFont = true;
            this.Password_tb.Properties.Appearance.Options.UseForeColor = true;
            this.Password_tb.Size = new System.Drawing.Size(217, 32);
            this.Password_tb.TabIndex = 13;
            // 
            // Username_tb
            // 
            this.Username_tb.Location = new System.Drawing.Point(196, 45);
            this.Username_tb.Name = "Username_tb";
            this.Username_tb.Properties.Appearance.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username_tb.Properties.Appearance.ForeColor = System.Drawing.Color.DodgerBlue;
            this.Username_tb.Properties.Appearance.Options.UseFont = true;
            this.Username_tb.Properties.Appearance.Options.UseForeColor = true;
            this.Username_tb.Size = new System.Drawing.Size(217, 32);
            this.Username_tb.TabIndex = 12;
            // 
            // RePass_lb
            // 
            this.RePass_lb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RePass_lb.Appearance.BackColor = System.Drawing.Color.PeachPuff;
            this.RePass_lb.Appearance.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RePass_lb.Appearance.ForeColor = System.Drawing.Color.RoyalBlue;
            this.RePass_lb.Appearance.Options.UseBackColor = true;
            this.RePass_lb.Appearance.Options.UseFont = true;
            this.RePass_lb.Appearance.Options.UseForeColor = true;
            this.RePass_lb.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.RePass_lb.Location = new System.Drawing.Point(34, 194);
            this.RePass_lb.Name = "RePass_lb";
            this.RePass_lb.Size = new System.Drawing.Size(119, 29);
            this.RePass_lb.TabIndex = 11;
            this.RePass_lb.Text = "Re-Password ";
            // 
            // Pass_lb
            // 
            this.Pass_lb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Pass_lb.Appearance.BackColor = System.Drawing.Color.PeachPuff;
            this.Pass_lb.Appearance.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pass_lb.Appearance.ForeColor = System.Drawing.Color.RoyalBlue;
            this.Pass_lb.Appearance.Options.UseBackColor = true;
            this.Pass_lb.Appearance.Options.UseFont = true;
            this.Pass_lb.Appearance.Options.UseForeColor = true;
            this.Pass_lb.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.Pass_lb.Location = new System.Drawing.Point(34, 117);
            this.Pass_lb.Name = "Pass_lb";
            this.Pass_lb.Size = new System.Drawing.Size(119, 29);
            this.Pass_lb.TabIndex = 10;
            this.Pass_lb.Text = "Password       ";
            // 
            // User_lb
            // 
            this.User_lb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.User_lb.Appearance.BackColor = System.Drawing.Color.PeachPuff;
            this.User_lb.Appearance.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.User_lb.Appearance.ForeColor = System.Drawing.Color.RoyalBlue;
            this.User_lb.Appearance.Options.UseBackColor = true;
            this.User_lb.Appearance.Options.UseFont = true;
            this.User_lb.Appearance.Options.UseForeColor = true;
            this.User_lb.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.User_lb.Location = new System.Drawing.Point(34, 46);
            this.User_lb.Name = "User_lb";
            this.User_lb.Size = new System.Drawing.Size(120, 29);
            this.User_lb.TabIndex = 9;
            this.User_lb.Text = "Username      ";
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureEdit1.Location = new System.Drawing.Point(0, 0);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Size = new System.Drawing.Size(246, 347);
            this.pictureEdit1.TabIndex = 0;
            // 
            // Signin_Account
            // 
            this.Appearance.BackColor = System.Drawing.Color.DarkCyan;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 347);
            this.Controls.Add(this.splitContainerControl1);
            this.Name = "Signin_Account";
            this.Text = "Enroll Account";
            this.Load += new System.EventHandler(this.Signin_Account_Load);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Repass_tb.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Password_tb.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Username_tb.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.SimpleButton Canncel_bt;
        private DevExpress.XtraEditors.SimpleButton SignIn_bt;
        private DevExpress.XtraEditors.TextEdit Repass_tb;
        private DevExpress.XtraEditors.TextEdit Password_tb;
        private DevExpress.XtraEditors.TextEdit Username_tb;
        private DevExpress.XtraEditors.LabelControl RePass_lb;
        private DevExpress.XtraEditors.LabelControl Pass_lb;
        private DevExpress.XtraEditors.LabelControl User_lb;
    }
}