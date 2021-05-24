
namespace General_Manager.Form
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.Username_tb = new DevExpress.XtraEditors.TextEdit();
            this.Password_tb = new DevExpress.XtraEditors.TextEdit();
            this.Exit_bt = new DevExpress.XtraEditors.SimpleButton();
            this.Login_bt = new DevExpress.XtraEditors.SimpleButton();
            this.GroupBox_role = new DevExpress.XtraEditors.GroupControl();
            this.Janitor_rbt = new System.Windows.Forms.RadioButton();
            this.Receptionist_rbt = new System.Windows.Forms.RadioButton();
            this.Manager_rbt = new System.Windows.Forms.RadioButton();
            this.Label_login = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Username_tb.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Password_tb.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GroupBox_role)).BeginInit();
            this.GroupBox_role.SuspendLayout();
            this.SuspendLayout();
            // 
            // Username_tb
            // 
            this.Username_tb.Location = new System.Drawing.Point(172, 109);
            this.Username_tb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Username_tb.Name = "Username_tb";
            this.Username_tb.Properties.ContextImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("Username_tb.Properties.ContextImageOptions.SvgImage")));
            this.Username_tb.Size = new System.Drawing.Size(331, 44);
            this.Username_tb.TabIndex = 2;
            // 
            // Password_tb
            // 
            this.Password_tb.Location = new System.Drawing.Point(172, 174);
            this.Password_tb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Password_tb.Name = "Password_tb";
            this.Password_tb.Properties.ContextImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("Password_tb.Properties.ContextImageOptions.SvgImage")));
            this.Password_tb.Size = new System.Drawing.Size(331, 44);
            this.Password_tb.TabIndex = 3;
            // 
            // Exit_bt
            // 
            this.Exit_bt.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Exit_bt.ImageOptions.Image")));
            this.Exit_bt.Location = new System.Drawing.Point(21, 398);
            this.Exit_bt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Exit_bt.Name = "Exit_bt";
            this.Exit_bt.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.Exit_bt.Size = new System.Drawing.Size(101, 71);
            this.Exit_bt.TabIndex = 4;
            this.Exit_bt.Text = "Exit";
            this.Exit_bt.Click += new System.EventHandler(this.Exit_bt_Click);
            // 
            // Login_bt
            // 
            this.Login_bt.Location = new System.Drawing.Point(172, 356);
            this.Login_bt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Login_bt.Name = "Login_bt";
            this.Login_bt.Size = new System.Drawing.Size(331, 48);
            this.Login_bt.TabIndex = 5;
            this.Login_bt.Text = "Login";
            this.Login_bt.Click += new System.EventHandler(this.Login_bt_Click);
            // 
            // GroupBox_role
            // 
            this.GroupBox_role.Controls.Add(this.Janitor_rbt);
            this.GroupBox_role.Controls.Add(this.Receptionist_rbt);
            this.GroupBox_role.Controls.Add(this.Manager_rbt);
            this.GroupBox_role.Location = new System.Drawing.Point(172, 255);
            this.GroupBox_role.Name = "GroupBox_role";
            this.GroupBox_role.Size = new System.Drawing.Size(331, 69);
            this.GroupBox_role.TabIndex = 9;
            this.GroupBox_role.Text = "Roles";
            // 
            // Janitor_rbt
            // 
            this.Janitor_rbt.AutoSize = true;
            this.Janitor_rbt.Location = new System.Drawing.Point(259, 28);
            this.Janitor_rbt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Janitor_rbt.Name = "Janitor_rbt";
            this.Janitor_rbt.Size = new System.Drawing.Size(70, 21);
            this.Janitor_rbt.TabIndex = 5;
            this.Janitor_rbt.Text = "Janitor";
            this.Janitor_rbt.UseVisualStyleBackColor = true;
            // 
            // Receptionist_rbt
            // 
            this.Receptionist_rbt.AutoSize = true;
            this.Receptionist_rbt.Location = new System.Drawing.Point(113, 28);
            this.Receptionist_rbt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Receptionist_rbt.Name = "Receptionist_rbt";
            this.Receptionist_rbt.Size = new System.Drawing.Size(103, 21);
            this.Receptionist_rbt.TabIndex = 4;
            this.Receptionist_rbt.Text = "Receptionist";
            this.Receptionist_rbt.UseVisualStyleBackColor = true;
            // 
            // Manager_rbt
            // 
            this.Manager_rbt.AutoSize = true;
            this.Manager_rbt.Checked = true;
            this.Manager_rbt.Location = new System.Drawing.Point(2, 28);
            this.Manager_rbt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Manager_rbt.Name = "Manager_rbt";
            this.Manager_rbt.Size = new System.Drawing.Size(81, 21);
            this.Manager_rbt.TabIndex = 3;
            this.Manager_rbt.TabStop = true;
            this.Manager_rbt.Text = "Manager";
            this.Manager_rbt.UseVisualStyleBackColor = true;
            // 
            // Label_login
            // 
            this.Label_login.AutoSize = true;
            this.Label_login.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_login.Location = new System.Drawing.Point(285, 24);
            this.Label_login.Name = "Label_login";
            this.Label_login.Size = new System.Drawing.Size(90, 30);
            this.Label_login.TabIndex = 10;
            this.Label_login.Text = "LOGIN";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 482);
            this.Controls.Add(this.Label_login);
            this.Controls.Add(this.GroupBox_role);
            this.Controls.Add(this.Login_bt);
            this.Controls.Add(this.Exit_bt);
            this.Controls.Add(this.Password_tb);
            this.Controls.Add(this.Username_tb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "77";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Username_tb.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Password_tb.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GroupBox_role)).EndInit();
            this.GroupBox_role.ResumeLayout(false);
            this.GroupBox_role.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.TextEdit Username_tb;
        private DevExpress.XtraEditors.TextEdit Password_tb;
        private DevExpress.XtraEditors.SimpleButton Exit_bt;
        private DevExpress.XtraEditors.SimpleButton Login_bt;
        private DevExpress.XtraEditors.GroupControl GroupBox_role;
        private System.Windows.Forms.RadioButton Janitor_rbt;
        private System.Windows.Forms.RadioButton Receptionist_rbt;
        private System.Windows.Forms.RadioButton Manager_rbt;
        private System.Windows.Forms.Label Label_login;
    }
}