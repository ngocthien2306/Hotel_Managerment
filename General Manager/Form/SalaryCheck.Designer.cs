
namespace General_Manager.Form
{
    partial class SalaryCheck
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalaryCheck));
            this.Label_id = new DevExpress.XtraEditors.LabelControl();
            this.Label_showid = new DevExpress.XtraEditors.LabelControl();
            this.Label_history = new DevExpress.XtraEditors.LabelControl();
            this.Treelist_History = new DevExpress.XtraTreeList.TreeList();
            this.Label_salary = new DevExpress.XtraEditors.LabelControl();
            this.hotel_ManagementDataSet = new General_Manager.Hotel_ManagementDataSet();
            this.empHistoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.empHistoryTableAdapter = new General_Manager.Hotel_ManagementDataSetTableAdapters.empHistoryTableAdapter();
            this.colId = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colfullname = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.coldaylog = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colrole = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.coldescription = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.Buton_checkSalaryperday = new DevExpress.XtraEditors.SimpleButton();
            this.ShowSalary_tb = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.Treelist_History)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotel_ManagementDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empHistoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShowSalary_tb.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // Label_id
            // 
            this.Label_id.Location = new System.Drawing.Point(45, 44);
            this.Label_id.Name = "Label_id";
            this.Label_id.Size = new System.Drawing.Size(53, 17);
            this.Label_id.TabIndex = 0;
            this.Label_id.Text = "Your ID: ";
            // 
            // Label_showid
            // 
            this.Label_showid.Location = new System.Drawing.Point(151, 44);
            this.Label_showid.Name = "Label_showid";
            this.Label_showid.Size = new System.Drawing.Size(56, 17);
            this.Label_showid.TabIndex = 1;
            this.Label_showid.Text = "00000000";
            // 
            // Label_history
            // 
            this.Label_history.Location = new System.Drawing.Point(45, 185);
            this.Label_history.Name = "Label_history";
            this.Label_history.Size = new System.Drawing.Size(93, 17);
            this.Label_history.TabIndex = 2;
            this.Label_history.Text = "Activity History";
            // 
            // Treelist_History
            // 
            this.Treelist_History.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.colId,
            this.colfullname,
            this.coldaylog,
            this.colrole,
            this.coldescription});
            this.Treelist_History.Cursor = System.Windows.Forms.Cursors.Default;
            this.Treelist_History.Location = new System.Drawing.Point(45, 258);
            this.Treelist_History.Name = "Treelist_History";
            this.Treelist_History.Size = new System.Drawing.Size(657, 223);
            this.Treelist_History.TabIndex = 3;
            // 
            // Label_salary
            // 
            this.Label_salary.Location = new System.Drawing.Point(45, 116);
            this.Label_salary.Name = "Label_salary";
            this.Label_salary.Size = new System.Drawing.Size(41, 17);
            this.Label_salary.TabIndex = 4;
            this.Label_salary.Text = "Salary:";
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
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.Visible = true;
            this.colId.VisibleIndex = 0;
            // 
            // colfullname
            // 
            this.colfullname.FieldName = "fullname";
            this.colfullname.Name = "colfullname";
            this.colfullname.Visible = true;
            this.colfullname.VisibleIndex = 1;
            // 
            // coldaylog
            // 
            this.coldaylog.FieldName = "daylog";
            this.coldaylog.Name = "coldaylog";
            this.coldaylog.Visible = true;
            this.coldaylog.VisibleIndex = 2;
            // 
            // colrole
            // 
            this.colrole.FieldName = "role";
            this.colrole.Name = "colrole";
            this.colrole.Visible = true;
            this.colrole.VisibleIndex = 3;
            // 
            // coldescription
            // 
            this.coldescription.FieldName = "description";
            this.coldescription.Name = "coldescription";
            this.coldescription.Visible = true;
            this.coldescription.VisibleIndex = 4;
            // 
            // Buton_checkSalaryperday
            // 
            this.Buton_checkSalaryperday.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("Buton_checkSalaryperday.ImageOptions.SvgImage")));
            this.Buton_checkSalaryperday.Location = new System.Drawing.Point(352, 102);
            this.Buton_checkSalaryperday.Name = "Buton_checkSalaryperday";
            this.Buton_checkSalaryperday.Size = new System.Drawing.Size(102, 43);
            this.Buton_checkSalaryperday.TabIndex = 6;
            this.Buton_checkSalaryperday.Text = "Check";
            this.Buton_checkSalaryperday.Click += new System.EventHandler(this.Buton_checkSalaryperday_Click);
            // 
            // ShowSalary_tb
            // 
            this.ShowSalary_tb.Location = new System.Drawing.Point(151, 113);
            this.ShowSalary_tb.Name = "ShowSalary_tb";
            this.ShowSalary_tb.Properties.ReadOnly = true;
            this.ShowSalary_tb.Size = new System.Drawing.Size(176, 24);
            this.ShowSalary_tb.TabIndex = 7;
            // 
            // SalaryCheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 514);
            this.Controls.Add(this.ShowSalary_tb);
            this.Controls.Add(this.Buton_checkSalaryperday);
            this.Controls.Add(this.Label_salary);
            this.Controls.Add(this.Treelist_History);
            this.Controls.Add(this.Label_history);
            this.Controls.Add(this.Label_showid);
            this.Controls.Add(this.Label_id);
            this.Name = "SalaryCheck";
            this.Text = "SalaryCheck";
            this.Load += new System.EventHandler(this.SalaryCheck_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Treelist_History)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotel_ManagementDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empHistoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShowSalary_tb.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraTreeList.TreeList Treelist_History;
        public DevExpress.XtraEditors.LabelControl Label_id;
        public DevExpress.XtraEditors.LabelControl Label_showid;
        public DevExpress.XtraEditors.LabelControl Label_history;
        public DevExpress.XtraEditors.LabelControl Label_salary;
        private Hotel_ManagementDataSet hotel_ManagementDataSet;
        private System.Windows.Forms.BindingSource empHistoryBindingSource;
        private Hotel_ManagementDataSetTableAdapters.empHistoryTableAdapter empHistoryTableAdapter;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colId;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colfullname;
        private DevExpress.XtraTreeList.Columns.TreeListColumn coldaylog;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colrole;
        private DevExpress.XtraTreeList.Columns.TreeListColumn coldescription;
        private DevExpress.XtraEditors.SimpleButton Buton_checkSalaryperday;
        private DevExpress.XtraEditors.TextEdit ShowSalary_tb;
    }
}