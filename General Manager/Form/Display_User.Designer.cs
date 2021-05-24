
namespace General_Manager.Form
{
    partial class Display_User
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
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.Watch = new DevExpress.XtraGrid.GridControl();
            this.Users = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Username = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Password = new DevExpress.XtraGrid.Columns.GridColumn();
            this.treeList1 = new DevExpress.XtraTreeList.TreeList();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Watch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Users)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.Watch);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.treeList1);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1010, 646);
            this.splitContainerControl1.SplitterPosition = 388;
            this.splitContainerControl1.TabIndex = 0;
            // 
            // Watch
            // 
            this.Watch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Watch.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Watch.Location = new System.Drawing.Point(0, 0);
            this.Watch.MainView = this.Users;
            this.Watch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Watch.Name = "Watch";
            this.Watch.Size = new System.Drawing.Size(388, 646);
            this.Watch.TabIndex = 0;
            this.Watch.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.Users});
            this.Watch.Load += new System.EventHandler(this.Watch_Load);
            // 
            // Users
            // 
            this.Users.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Username,
            this.Password});
            this.Users.DetailHeight = 431;
            this.Users.GridControl = this.Watch;
            this.Users.Name = "Users";
            // 
            // Username
            // 
            this.Username.Caption = "Username";
            this.Username.MinWidth = 23;
            this.Username.Name = "Username";
            this.Username.Visible = true;
            this.Username.VisibleIndex = 0;
            this.Username.Width = 87;
            // 
            // Password
            // 
            this.Password.Caption = "Password";
            this.Password.MinWidth = 23;
            this.Password.Name = "Password";
            this.Password.Visible = true;
            this.Password.VisibleIndex = 1;
            this.Password.Width = 87;
            // 
            // treeList1
            // 
            this.treeList1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeList1.Location = new System.Drawing.Point(0, 0);
            this.treeList1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.treeList1.MinWidth = 23;
            this.treeList1.Name = "treeList1";
            this.treeList1.Size = new System.Drawing.Size(616, 646);
            this.treeList1.TabIndex = 0;
            this.treeList1.TreeLevelWidth = 21;
            // 
            // Display_User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 646);
            this.Controls.Add(this.splitContainerControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Display_User";
            this.Text = "Display_User";
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Watch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Users)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView Users;
        private DevExpress.XtraGrid.Columns.GridColumn Username;
        private DevExpress.XtraGrid.Columns.GridColumn Password;
        private DevExpress.XtraTreeList.TreeList treeList1;
        public DevExpress.XtraGrid.GridControl Watch;
    }
}