
namespace General_Manager.Form
{
    partial class Salary_Perday
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Salary_Perday));
            this.schedulerDataStorage1 = new DevExpress.XtraScheduler.SchedulerDataStorage(this.components);
            this.schedulerBarController1 = new DevExpress.XtraScheduler.UI.SchedulerBarController(this.components);
            this.Label_id = new DevExpress.XtraEditors.LabelControl();
            this.Check_btn = new DevExpress.XtraEditors.SimpleButton();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.Label_his = new System.Windows.Forms.Label();
            this.Label_salary = new System.Windows.Forms.Label();
            this.listBoxControl1 = new DevExpress.XtraEditors.ListBoxControl();
            this.hotel_ManagementDataSet = new General_Manager.Hotel_ManagementDataSet();
            this.empHistoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.empHistoryTableAdapter = new General_Manager.Hotel_ManagementDataSetTableAdapters.empHistoryTableAdapter();
            this.TextBox_salary = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerDataStorage1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerBarController1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listBoxControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotel_ManagementDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empHistoryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // schedulerDataStorage1
            // 
            // 
            // 
            // 
            this.schedulerDataStorage1.AppointmentDependencies.AutoReload = false;
            // 
            // Label_id
            // 
            this.Label_id.Appearance.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_id.Appearance.Options.UseFont = true;
            this.Label_id.Location = new System.Drawing.Point(38, 53);
            this.Label_id.Name = "Label_id";
            this.Label_id.Size = new System.Drawing.Size(59, 20);
            this.Label_id.TabIndex = 0;
            this.Label_id.Text = "Your ID: ";
            // 
            // Check_btn
            // 
            this.Check_btn.Appearance.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Check_btn.Appearance.Options.UseFont = true;
            this.Check_btn.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("Check_btn.ImageOptions.SvgImage")));
            this.Check_btn.Location = new System.Drawing.Point(623, 36);
            this.Check_btn.Name = "Check_btn";
            this.Check_btn.Size = new System.Drawing.Size(123, 53);
            this.Check_btn.TabIndex = 1;
            this.Check_btn.Text = "Check";
            // 
            // textEdit1
            // 
            this.textEdit1.Location = new System.Drawing.Point(167, 50);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Properties.Appearance.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEdit1.Properties.Appearance.Options.UseFont = true;
            this.textEdit1.Size = new System.Drawing.Size(418, 26);
            this.textEdit1.TabIndex = 2;
            // 
            // Label_his
            // 
            this.Label_his.AutoSize = true;
            this.Label_his.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_his.Location = new System.Drawing.Point(34, 186);
            this.Label_his.Name = "Label_his";
            this.Label_his.Size = new System.Drawing.Size(56, 20);
            this.Label_his.TabIndex = 3;
            this.Label_his.Text = "History";
            // 
            // Label_salary
            // 
            this.Label_salary.AutoSize = true;
            this.Label_salary.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_salary.Location = new System.Drawing.Point(248, 186);
            this.Label_salary.Name = "Label_salary";
            this.Label_salary.Size = new System.Drawing.Size(52, 20);
            this.Label_salary.TabIndex = 5;
            this.Label_salary.Text = "Salary";
            // 
            // listBoxControl1
            // 
            this.listBoxControl1.DataSource = this.empHistoryBindingSource;
            this.listBoxControl1.DisplayMember = "description";
            this.listBoxControl1.Location = new System.Drawing.Point(38, 233);
            this.listBoxControl1.Name = "listBoxControl1";
            this.listBoxControl1.Size = new System.Drawing.Size(173, 122);
            this.listBoxControl1.TabIndex = 6;
            this.listBoxControl1.ValueMember = "Id";
            // 
            // hotel_ManagementDataSet
            // 
            this.hotel_ManagementDataSet.DataSetName = "Hotel_ManagementDataSet";
            this.hotel_ManagementDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // empHistoryBindingSource
            // 
            this.empHistoryBindingSource.DataMember = "empHistory";
            this.empHistoryBindingSource.DataSource = this.hotel_ManagementDataSet;
            // 
            // empHistoryTableAdapter
            // 
            this.empHistoryTableAdapter.ClearBeforeFill = true;
            // 
            // TextBox_salary
            // 
            this.TextBox_salary.Location = new System.Drawing.Point(335, 183);
            this.TextBox_salary.Multiline = true;
            this.TextBox_salary.Name = "TextBox_salary";
            this.TextBox_salary.Size = new System.Drawing.Size(250, 22);
            this.TextBox_salary.TabIndex = 7;
            // 
            // Salary_Perday
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 367);
            this.Controls.Add(this.TextBox_salary);
            this.Controls.Add(this.listBoxControl1);
            this.Controls.Add(this.Label_salary);
            this.Controls.Add(this.Label_his);
            this.Controls.Add(this.textEdit1);
            this.Controls.Add(this.Check_btn);
            this.Controls.Add(this.Label_id);
            this.Name = "Salary_Perday";
            this.Text = "Salary_Perday";
            this.Load += new System.EventHandler(this.Salary_Perday_Load);
            ((System.ComponentModel.ISupportInitialize)(this.schedulerDataStorage1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerBarController1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listBoxControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotel_ManagementDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empHistoryBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraScheduler.SchedulerDataStorage schedulerDataStorage1;
        private DevExpress.XtraScheduler.UI.SchedulerBarController schedulerBarController1;
        private DevExpress.XtraEditors.LabelControl Label_id;
        private DevExpress.XtraEditors.SimpleButton Check_btn;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private System.Windows.Forms.Label Label_his;
        private System.Windows.Forms.Label Label_salary;
        private DevExpress.XtraEditors.ListBoxControl listBoxControl1;
        private Hotel_ManagementDataSet hotel_ManagementDataSet;
        private System.Windows.Forms.BindingSource empHistoryBindingSource;
        private Hotel_ManagementDataSetTableAdapters.empHistoryTableAdapter empHistoryTableAdapter;
        private System.Windows.Forms.TextBox TextBox_salary;
    }
}