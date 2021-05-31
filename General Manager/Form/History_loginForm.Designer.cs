
namespace General_Manager.Form
{
    partial class History_loginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(History_loginForm));
            this.fluentDesignFormContainer1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer();
            this.empHistoryGridControl = new DevExpress.XtraGrid.GridControl();
            this.empHistoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hotel_ManagementDataSet = new General_Manager.Hotel_ManagementDataSet();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfullname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldaylog = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colrole = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.accordionControl1 = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.accordionControlElement1 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.HistoryDelete_btn = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.fluentDesignFormControl1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl();
            this.empHistoryTableAdapter = new General_Manager.Hotel_ManagementDataSetTableAdapters.empHistoryTableAdapter();
            this.tableAdapterManager = new General_Manager.Hotel_ManagementDataSetTableAdapters.TableAdapterManager();
            this.Reload_btn = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.Printlist_btn = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.Find_btn = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.fluentDesignFormContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.empHistoryGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empHistoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotel_ManagementDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // fluentDesignFormContainer1
            // 
            this.fluentDesignFormContainer1.Controls.Add(this.empHistoryGridControl);
            this.fluentDesignFormContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fluentDesignFormContainer1.Location = new System.Drawing.Point(260, 34);
            this.fluentDesignFormContainer1.Name = "fluentDesignFormContainer1";
            this.fluentDesignFormContainer1.Size = new System.Drawing.Size(1089, 782);
            this.fluentDesignFormContainer1.TabIndex = 0;
            // 
            // empHistoryGridControl
            // 
            this.empHistoryGridControl.DataSource = this.empHistoryBindingSource;
            this.empHistoryGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.empHistoryGridControl.Location = new System.Drawing.Point(0, 0);
            this.empHistoryGridControl.MainView = this.gridView1;
            this.empHistoryGridControl.Name = "empHistoryGridControl";
            this.empHistoryGridControl.Size = new System.Drawing.Size(1089, 782);
            this.empHistoryGridControl.TabIndex = 0;
            this.empHistoryGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // empHistoryBindingSource
            // 
            this.empHistoryBindingSource.DataMember = "empHistory";
            this.empHistoryBindingSource.DataSource = this.hotel_ManagementDataSet;
            // 
            // hotel_ManagementDataSet
            // 
            this.hotel_ManagementDataSet.DataSetName = "Hotel_ManagementDataSet";
            this.hotel_ManagementDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colfullname,
            this.coldaylog,
            this.colrole,
            this.coldescription});
            this.gridView1.GridControl = this.empHistoryGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowPreview = true;
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.MinWidth = 25;
            this.colId.Name = "colId";
            this.colId.OptionsColumn.ReadOnly = true;
            this.colId.Visible = true;
            this.colId.VisibleIndex = 0;
            this.colId.Width = 94;
            // 
            // colfullname
            // 
            this.colfullname.FieldName = "fullname";
            this.colfullname.MinWidth = 25;
            this.colfullname.Name = "colfullname";
            this.colfullname.OptionsColumn.ReadOnly = true;
            this.colfullname.Visible = true;
            this.colfullname.VisibleIndex = 1;
            this.colfullname.Width = 94;
            // 
            // coldaylog
            // 
            this.coldaylog.FieldName = "daylog";
            this.coldaylog.GroupFormat.FormatString = "hh/dd/mm/yyyy";
            this.coldaylog.GroupFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.coldaylog.MinWidth = 25;
            this.coldaylog.Name = "coldaylog";
            this.coldaylog.OptionsColumn.ReadOnly = true;
            this.coldaylog.Visible = true;
            this.coldaylog.VisibleIndex = 2;
            this.coldaylog.Width = 94;
            // 
            // colrole
            // 
            this.colrole.FieldName = "role";
            this.colrole.MinWidth = 25;
            this.colrole.Name = "colrole";
            this.colrole.OptionsColumn.ReadOnly = true;
            this.colrole.Visible = true;
            this.colrole.VisibleIndex = 3;
            this.colrole.Width = 94;
            // 
            // coldescription
            // 
            this.coldescription.FieldName = "description";
            this.coldescription.MinWidth = 25;
            this.coldescription.Name = "coldescription";
            this.coldescription.OptionsColumn.ReadOnly = true;
            this.coldescription.Visible = true;
            this.coldescription.VisibleIndex = 4;
            this.coldescription.Width = 94;
            // 
            // accordionControl1
            // 
            this.accordionControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.accordionControl1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlElement1,
            this.Find_btn,
            this.Printlist_btn,
            this.Reload_btn,
            this.HistoryDelete_btn});
            this.accordionControl1.Location = new System.Drawing.Point(0, 34);
            this.accordionControl1.Name = "accordionControl1";
            this.accordionControl1.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Touch;
            this.accordionControl1.Size = new System.Drawing.Size(260, 782);
            this.accordionControl1.TabIndex = 1;
            this.accordionControl1.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu;
            // 
            // accordionControlElement1
            // 
            this.accordionControlElement1.Expanded = true;
            this.accordionControlElement1.Name = "accordionControlElement1";
            this.accordionControlElement1.Text = "Element1";
            // 
            // HistoryDelete_btn
            // 
            this.HistoryDelete_btn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlElement2.ImageOptions.Image1")));
            this.HistoryDelete_btn.Name = "HistoryDelete_btn";
            this.HistoryDelete_btn.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.HistoryDelete_btn.Text = "Delete History";
            this.HistoryDelete_btn.Click += new System.EventHandler(this.HistoryDelete_btn_Click);
            // 
            // fluentDesignFormControl1
            // 
            this.fluentDesignFormControl1.FluentDesignForm = this;
            this.fluentDesignFormControl1.Location = new System.Drawing.Point(0, 0);
            this.fluentDesignFormControl1.Name = "fluentDesignFormControl1";
            this.fluentDesignFormControl1.Size = new System.Drawing.Size(1349, 34);
            this.fluentDesignFormControl1.TabIndex = 2;
            this.fluentDesignFormControl1.TabStop = false;
            // 
            // empHistoryTableAdapter
            // 
            this.empHistoryTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Check_inTableAdapter = null;
            this.tableAdapterManager.Check_outTableAdapter = null;
            this.tableAdapterManager.cusHistoryTableAdapter = null;
            this.tableAdapterManager.CustomerTableAdapter = null;
            this.tableAdapterManager.empHistoryTableAdapter = this.empHistoryTableAdapter;
            this.tableAdapterManager.Employee_PositionTableAdapter = null;
            this.tableAdapterManager.Employee_posTableAdapter = null;
            this.tableAdapterManager.EmployeeTableAdapter = null;
            this.tableAdapterManager.Manage_empTableAdapter = null;
            this.tableAdapterManager.Monney_TransactionTableAdapter = null;
            this.tableAdapterManager.PositionTableAdapter = null;
            this.tableAdapterManager.RoomTableAdapter = null;
            this.tableAdapterManager.RoomTypeTableAdapter = null;
            this.tableAdapterManager.ScheduleTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = General_Manager.Hotel_ManagementDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.WorkShiftTableAdapter = null;
            // 
            // Reload_btn
            // 
            this.Reload_btn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlElement2.ImageOptions.Image")));
            this.Reload_btn.Name = "Reload_btn";
            this.Reload_btn.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.Reload_btn.Text = "Re-Load";
            this.Reload_btn.Click += new System.EventHandler(this.Reload_btn_Click);
            // 
            // Printlist_btn
            // 
            this.Printlist_btn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlElement3.ImageOptions.Image")));
            this.Printlist_btn.Name = "Printlist_btn";
            this.Printlist_btn.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.Printlist_btn.Text = "Print List";
            this.Printlist_btn.Click += new System.EventHandler(this.Printlist_btn_Click);
            // 
            // Find_btn
            // 
            this.Find_btn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlElement4.ImageOptions.Image")));
            this.Find_btn.Name = "Find_btn";
            this.Find_btn.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.Find_btn.Text = "Find";
            this.Find_btn.Click += new System.EventHandler(this.Find_btn_Click);
            // 
            // History_loginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1349, 816);
            this.ControlContainer = this.fluentDesignFormContainer1;
            this.Controls.Add(this.fluentDesignFormContainer1);
            this.Controls.Add(this.accordionControl1);
            this.Controls.Add(this.fluentDesignFormControl1);
            this.FluentDesignFormControl = this.fluentDesignFormControl1;
            this.Name = "History_loginForm";
            this.NavigationControl = this.accordionControl1;
            this.Text = "History_loginForm";
            this.Load += new System.EventHandler(this.History_loginForm_Load);
            this.fluentDesignFormContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.empHistoryGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empHistoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotel_ManagementDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer fluentDesignFormContainer1;
        private DevExpress.XtraBars.Navigation.AccordionControl accordionControl1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement1;
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl fluentDesignFormControl1;
        private System.Windows.Forms.BindingSource empHistoryBindingSource;
        private Hotel_ManagementDataSet hotel_ManagementDataSet;
        private Hotel_ManagementDataSetTableAdapters.empHistoryTableAdapter empHistoryTableAdapter;
        private Hotel_ManagementDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl empHistoryGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colfullname;
        private DevExpress.XtraGrid.Columns.GridColumn coldaylog;
        private DevExpress.XtraGrid.Columns.GridColumn colrole;
        private DevExpress.XtraGrid.Columns.GridColumn coldescription;
        private DevExpress.XtraBars.Navigation.AccordionControlElement HistoryDelete_btn;
        private DevExpress.XtraBars.Navigation.AccordionControlElement Find_btn;
        private DevExpress.XtraBars.Navigation.AccordionControlElement Printlist_btn;
        private DevExpress.XtraBars.Navigation.AccordionControlElement Reload_btn;
    }
}