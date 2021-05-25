
namespace General_Manager.Form
{
    partial class Attendance
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
            this.ID_tb = new DevExpress.XtraEditors.TextEdit();
            this.ID_lb = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.Date_tb = new DevExpress.XtraEditors.TextEdit();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.Time_tb = new DevExpress.XtraEditors.TextEdit();
            this.Checkin_btn = new System.Windows.Forms.Button();
            this.Checkout_btn = new System.Windows.Forms.Button();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.End_lb = new DevExpress.XtraEditors.LabelControl();
            this.Start_lb = new DevExpress.XtraEditors.LabelControl();
            this.End_tb = new DevExpress.XtraEditors.TextEdit();
            this.Start_tb = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.ID_tb.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Date_tb.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Time_tb.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.End_tb.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Start_tb.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // ID_tb
            // 
            this.ID_tb.Enabled = false;
            this.ID_tb.Location = new System.Drawing.Point(82, 12);
            this.ID_tb.Name = "ID_tb";
            this.ID_tb.Properties.Appearance.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID_tb.Properties.Appearance.Options.UseFont = true;
            this.ID_tb.Properties.AppearanceDisabled.BorderColor = System.Drawing.Color.Black;
            this.ID_tb.Properties.AppearanceDisabled.Font = new System.Drawing.Font("Bahnschrift SemiLight", 12F);
            this.ID_tb.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black;
            this.ID_tb.Properties.AppearanceDisabled.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.ID_tb.Properties.AppearanceDisabled.Options.UseBorderColor = true;
            this.ID_tb.Properties.AppearanceDisabled.Options.UseFont = true;
            this.ID_tb.Properties.AppearanceDisabled.Options.UseForeColor = true;
            this.ID_tb.Properties.AppearanceDisabled.Options.UseTextOptions = true;
            this.ID_tb.Properties.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ID_tb.Properties.AppearanceDisabled.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.ID_tb.Size = new System.Drawing.Size(100, 22);
            this.ID_tb.TabIndex = 0;
            // 
            // ID_lb
            // 
            this.ID_lb.Appearance.Font = new System.Drawing.Font("Bahnschrift SemiLight", 12F);
            this.ID_lb.Appearance.Options.UseFont = true;
            this.ID_lb.Location = new System.Drawing.Point(5, 12);
            this.ID_lb.Name = "ID_lb";
            this.ID_lb.Size = new System.Drawing.Size(75, 19);
            this.ID_lb.TabIndex = 1;
            this.ID_lb.Text = "Current ID";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Bahnschrift SemiLight", 12F);
            this.labelControl2.Appearance.Options.UseBackColor = true;
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(163, 5);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(95, 19);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Current Time";
            // 
            // Date_tb
            // 
            this.Date_tb.Enabled = false;
            this.Date_tb.Location = new System.Drawing.Point(142, 30);
            this.Date_tb.Name = "Date_tb";
            this.Date_tb.Properties.Appearance.Font = new System.Drawing.Font("Bahnschrift SemiLight", 12F);
            this.Date_tb.Properties.Appearance.Options.UseFont = true;
            this.Date_tb.Properties.AppearanceDisabled.BorderColor = System.Drawing.Color.Black;
            this.Date_tb.Properties.AppearanceDisabled.Font = new System.Drawing.Font("Bahnschrift SemiLight", 12F);
            this.Date_tb.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black;
            this.Date_tb.Properties.AppearanceDisabled.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.Date_tb.Properties.AppearanceDisabled.Options.UseBorderColor = true;
            this.Date_tb.Properties.AppearanceDisabled.Options.UseFont = true;
            this.Date_tb.Properties.AppearanceDisabled.Options.UseForeColor = true;
            this.Date_tb.Properties.AppearanceDisabled.Options.UseTextOptions = true;
            this.Date_tb.Properties.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Date_tb.Properties.AppearanceDisabled.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.Date_tb.Size = new System.Drawing.Size(136, 26);
            this.Date_tb.TabIndex = 3;
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Time_tb
            // 
            this.Time_tb.Enabled = false;
            this.Time_tb.Location = new System.Drawing.Point(142, 62);
            this.Time_tb.Name = "Time_tb";
            this.Time_tb.Properties.Appearance.Font = new System.Drawing.Font("Bahnschrift SemiLight", 12F);
            this.Time_tb.Properties.Appearance.Options.UseFont = true;
            this.Time_tb.Properties.AppearanceDisabled.BorderColor = System.Drawing.Color.Black;
            this.Time_tb.Properties.AppearanceDisabled.Font = new System.Drawing.Font("Bahnschrift SemiLight", 12F);
            this.Time_tb.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black;
            this.Time_tb.Properties.AppearanceDisabled.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.Time_tb.Properties.AppearanceDisabled.Options.UseBorderColor = true;
            this.Time_tb.Properties.AppearanceDisabled.Options.UseFont = true;
            this.Time_tb.Properties.AppearanceDisabled.Options.UseForeColor = true;
            this.Time_tb.Properties.AppearanceDisabled.Options.UseTextOptions = true;
            this.Time_tb.Properties.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Time_tb.Properties.AppearanceDisabled.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.Time_tb.Size = new System.Drawing.Size(136, 26);
            this.Time_tb.TabIndex = 4;
            // 
            // Checkin_btn
            // 
            this.Checkin_btn.Font = new System.Drawing.Font("Bahnschrift SemiLight", 12F);
            this.Checkin_btn.Location = new System.Drawing.Point(24, 33);
            this.Checkin_btn.Name = "Checkin_btn";
            this.Checkin_btn.Size = new System.Drawing.Size(91, 55);
            this.Checkin_btn.TabIndex = 5;
            this.Checkin_btn.Text = "Check In";
            this.Checkin_btn.UseVisualStyleBackColor = true;
            this.Checkin_btn.Click += new System.EventHandler(this.Checkin_btn_Click);
            // 
            // Checkout_btn
            // 
            this.Checkout_btn.Font = new System.Drawing.Font("Bahnschrift SemiLight", 12F);
            this.Checkout_btn.Location = new System.Drawing.Point(303, 33);
            this.Checkout_btn.Name = "Checkout_btn";
            this.Checkout_btn.Size = new System.Drawing.Size(91, 55);
            this.Checkout_btn.TabIndex = 6;
            this.Checkout_btn.Text = "Check Out";
            this.Checkout_btn.UseVisualStyleBackColor = true;
            this.Checkout_btn.Click += new System.EventHandler(this.Checkout_btn_Click);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.Time_tb);
            this.panelControl1.Controls.Add(this.Checkout_btn);
            this.panelControl1.Controls.Add(this.Date_tb);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.Checkin_btn);
            this.panelControl1.Location = new System.Drawing.Point(13, 103);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(417, 128);
            this.panelControl1.TabIndex = 7;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.ID_tb);
            this.panelControl2.Controls.Add(this.ID_lb);
            this.panelControl2.Location = new System.Drawing.Point(13, 13);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(187, 46);
            this.panelControl2.TabIndex = 8;
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.End_lb);
            this.panelControl3.Controls.Add(this.Start_lb);
            this.panelControl3.Controls.Add(this.End_tb);
            this.panelControl3.Controls.Add(this.Start_tb);
            this.panelControl3.Location = new System.Drawing.Point(215, 12);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(215, 70);
            this.panelControl3.TabIndex = 9;
            // 
            // End_lb
            // 
            this.End_lb.Appearance.Font = new System.Drawing.Font("Bahnschrift SemiLight", 12F);
            this.End_lb.Appearance.Options.UseFont = true;
            this.End_lb.Location = new System.Drawing.Point(5, 40);
            this.End_lb.Name = "End_lb";
            this.End_lb.Size = new System.Drawing.Size(28, 19);
            this.End_lb.TabIndex = 11;
            this.End_lb.Text = "End";
            // 
            // Start_lb
            // 
            this.Start_lb.Appearance.Font = new System.Drawing.Font("Bahnschrift SemiLight", 12F);
            this.Start_lb.Appearance.Options.UseFont = true;
            this.Start_lb.Location = new System.Drawing.Point(5, 8);
            this.Start_lb.Name = "Start_lb";
            this.Start_lb.Size = new System.Drawing.Size(36, 19);
            this.Start_lb.TabIndex = 10;
            this.Start_lb.Text = "Start";
            // 
            // End_tb
            // 
            this.End_tb.Enabled = false;
            this.End_tb.Location = new System.Drawing.Point(47, 37);
            this.End_tb.Name = "End_tb";
            this.End_tb.Properties.Appearance.Font = new System.Drawing.Font("Bahnschrift SemiLight", 12F);
            this.End_tb.Properties.Appearance.Options.UseFont = true;
            this.End_tb.Properties.AppearanceDisabled.BorderColor = System.Drawing.Color.Black;
            this.End_tb.Properties.AppearanceDisabled.Font = new System.Drawing.Font("Bahnschrift SemiLight", 12F);
            this.End_tb.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black;
            this.End_tb.Properties.AppearanceDisabled.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.End_tb.Properties.AppearanceDisabled.Options.UseBorderColor = true;
            this.End_tb.Properties.AppearanceDisabled.Options.UseFont = true;
            this.End_tb.Properties.AppearanceDisabled.Options.UseForeColor = true;
            this.End_tb.Properties.AppearanceDisabled.Options.UseTextOptions = true;
            this.End_tb.Properties.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.End_tb.Properties.AppearanceDisabled.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.End_tb.Size = new System.Drawing.Size(163, 26);
            this.End_tb.TabIndex = 5;
            // 
            // Start_tb
            // 
            this.Start_tb.Enabled = false;
            this.Start_tb.Location = new System.Drawing.Point(47, 5);
            this.Start_tb.Name = "Start_tb";
            this.Start_tb.Properties.Appearance.Font = new System.Drawing.Font("Bahnschrift SemiLight", 12F);
            this.Start_tb.Properties.Appearance.Options.UseFont = true;
            this.Start_tb.Properties.AppearanceDisabled.BorderColor = System.Drawing.Color.Black;
            this.Start_tb.Properties.AppearanceDisabled.Font = new System.Drawing.Font("Bahnschrift SemiLight", 12F);
            this.Start_tb.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black;
            this.Start_tb.Properties.AppearanceDisabled.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.Start_tb.Properties.AppearanceDisabled.Options.UseBorderColor = true;
            this.Start_tb.Properties.AppearanceDisabled.Options.UseFont = true;
            this.Start_tb.Properties.AppearanceDisabled.Options.UseForeColor = true;
            this.Start_tb.Properties.AppearanceDisabled.Options.UseTextOptions = true;
            this.Start_tb.Properties.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Start_tb.Properties.AppearanceDisabled.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.Start_tb.Size = new System.Drawing.Size(164, 26);
            this.Start_tb.TabIndex = 4;
            // 
            // Attendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 244);
            this.Controls.Add(this.panelControl3);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Name = "Attendance";
            this.Text = "Attendance";
            this.Load += new System.EventHandler(this.Attendance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ID_tb.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Date_tb.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Time_tb.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            this.panelControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.End_tb.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Start_tb.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit ID_tb;
        private DevExpress.XtraEditors.LabelControl ID_lb;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit Date_tb;
        public System.Windows.Forms.Timer timer;
        private DevExpress.XtraEditors.TextEdit Time_tb;
        private System.Windows.Forms.Button Checkin_btn;
        private System.Windows.Forms.Button Checkout_btn;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.LabelControl End_lb;
        private DevExpress.XtraEditors.LabelControl Start_lb;
        private DevExpress.XtraEditors.TextEdit End_tb;
        private DevExpress.XtraEditors.TextEdit Start_tb;
    }
}