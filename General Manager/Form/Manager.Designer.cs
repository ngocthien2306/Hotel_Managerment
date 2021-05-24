
namespace General_Manager.Form
{
    partial class Manager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Manager));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.M010101 = new DevExpress.XtraBars.BarButtonItem();
            this.M010102 = new DevExpress.XtraBars.BarButtonItem();
            this.M010103 = new DevExpress.XtraBars.BarButtonItem();
            this.M010201 = new DevExpress.XtraBars.BarButtonItem();
            this.M010202 = new DevExpress.XtraBars.BarButtonItem();
            this.M010203 = new DevExpress.XtraBars.BarButtonItem();
            this.m010301 = new DevExpress.XtraBars.BarButtonItem();
            this.m010302 = new DevExpress.XtraBars.BarButtonItem();
            this.m010303 = new DevExpress.XtraBars.BarButtonItem();
            this.m010401 = new DevExpress.XtraBars.BarButtonItem();
            this.m010402 = new DevExpress.XtraBars.BarButtonItem();
            this.m010403 = new DevExpress.XtraBars.BarButtonItem();
            this.m010501 = new DevExpress.XtraBars.BarButtonItem();
            this.m010502 = new DevExpress.XtraBars.BarButtonItem();
            this.m010503 = new DevExpress.XtraBars.BarButtonItem();
            this.Change_Interface = new DevExpress.XtraBars.SkinRibbonGalleryBarItem();
            this.Interface = new DevExpress.XtraBars.SkinRibbonGalleryBarItem();
            this.m01 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.m0101 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.m0102 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.m0103 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.m0104 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.m0105 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.Theme = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.m02 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.ribbon.SearchEditItem,
            this.M010101,
            this.M010102,
            this.M010103,
            this.M010201,
            this.M010202,
            this.M010203,
            this.m010301,
            this.m010302,
            this.m010303,
            this.m010401,
            this.m010402,
            this.m010403,
            this.m010501,
            this.m010502,
            this.m010503,
            this.Change_Interface,
            this.Interface});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 20;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.m01,
            this.m02});
            this.ribbon.Size = new System.Drawing.Size(897, 143);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            this.ribbon.Click += new System.EventHandler(this.ribbon_Click);
            // 
            // M010101
            // 
            this.M010101.Caption = "Log Out";
            this.M010101.Id = 1;
            this.M010101.Name = "M010101";
            this.M010101.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.M010101_ItemClick);
            // 
            // M010102
            // 
            this.M010102.Caption = "Lock Program";
            this.M010102.Id = 2;
            this.M010102.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("M010102.ImageOptions.Image")));
            this.M010102.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("M010102.ImageOptions.LargeImage")));
            this.M010102.Name = "M010102";
            // 
            // M010103
            // 
            this.M010103.Caption = "Exit";
            this.M010103.Id = 3;
            this.M010103.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("M010103.ImageOptions.Image")));
            this.M010103.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("M010103.ImageOptions.LargeImage")));
            this.M010103.Name = "M010103";
            this.M010103.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.M010103_ItemClick);
            // 
            // M010201
            // 
            this.M010201.Caption = "Manager Users";
            this.M010201.Id = 4;
            this.M010201.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("M010201.ImageOptions.Image")));
            this.M010201.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("M010201.ImageOptions.LargeImage")));
            this.M010201.Name = "M010201";
            this.M010201.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.M010201_ItemClick);
            // 
            // M010202
            // 
            this.M010202.Caption = "Re-Password";
            this.M010202.Id = 5;
            this.M010202.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("M010202.ImageOptions.Image")));
            this.M010202.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("M010202.ImageOptions.LargeImage")));
            this.M010202.Name = "M010202";
            this.M010202.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.M010202_ItemClick);
            // 
            // M010203
            // 
            this.M010203.Caption = "History Login";
            this.M010203.Id = 6;
            this.M010203.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("M010203.ImageOptions.Image")));
            this.M010203.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("M010203.ImageOptions.LargeImage")));
            this.M010203.Name = "M010203";
            // 
            // m010301
            // 
            this.m010301.Caption = "Work-Schedule";
            this.m010301.Id = 7;
            this.m010301.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("m010301.ImageOptions.SvgImage")));
            this.m010301.Name = "m010301";
            // 
            // m010302
            // 
            this.m010302.Caption = "Salary";
            this.m010302.Id = 8;
            this.m010302.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("m010302.ImageOptions.SvgImage")));
            this.m010302.Name = "m010302";
            // 
            // m010303
            // 
            this.m010303.Caption = "Activities";
            this.m010303.Id = 9;
            this.m010303.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("m010303.ImageOptions.Image")));
            this.m010303.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("m010303.ImageOptions.LargeImage")));
            this.m010303.Name = "m010303";
            // 
            // m010401
            // 
            this.m010401.Caption = "Employee";
            this.m010401.Id = 10;
            this.m010401.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("m010401.ImageOptions.SvgImage")));
            this.m010401.Name = "m010401";
            // 
            // m010402
            // 
            this.m010402.Caption = "Finance";
            this.m010402.Id = 11;
            this.m010402.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("m010402.ImageOptions.SvgImage")));
            this.m010402.Name = "m010402";
            // 
            // m010403
            // 
            this.m010403.Caption = "Times";
            this.m010403.Id = 12;
            this.m010403.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("m010403.ImageOptions.SvgImage")));
            this.m010403.Name = "m010403";
            // 
            // m010501
            // 
            this.m010501.Caption = "Add";
            this.m010501.Id = 13;
            this.m010501.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("m010501.ImageOptions.Image")));
            this.m010501.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("m010501.ImageOptions.LargeImage")));
            this.m010501.Name = "m010501";
            // 
            // m010502
            // 
            this.m010502.Caption = "Delete";
            this.m010502.Id = 14;
            this.m010502.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("m010502.ImageOptions.Image")));
            this.m010502.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("m010502.ImageOptions.LargeImage")));
            this.m010502.Name = "m010502";
            // 
            // m010503
            // 
            this.m010503.Caption = "Edit";
            this.m010503.Id = 15;
            this.m010503.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("m010503.ImageOptions.Image")));
            this.m010503.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("m010503.ImageOptions.LargeImage")));
            this.m010503.Name = "m010503";
            // 
            // Change_Interface
            // 
            this.Change_Interface.Caption = "Color";
            this.Change_Interface.Id = 17;
            this.Change_Interface.Name = "Change_Interface";
            // 
            // Interface
            // 
            this.Interface.Caption = "Graphics";
            this.Interface.Id = 19;
            this.Interface.Name = "Interface";
            // 
            // m01
            // 
            this.m01.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.m0101,
            this.m0102,
            this.m0103,
            this.m0104,
            this.m0105,
            this.Theme});
            this.m01.Name = "m01";
            this.m01.Text = "General Manager";
            // 
            // m0101
            // 
            this.m0101.ItemLinks.Add(this.M010101);
            this.m0101.ItemLinks.Add(this.M010102);
            this.m0101.ItemLinks.Add(this.M010103);
            this.m0101.Name = "m0101";
            this.m0101.Text = "Systems";
            // 
            // m0102
            // 
            this.m0102.ItemLinks.Add(this.M010201);
            this.m0102.ItemLinks.Add(this.M010202);
            this.m0102.ItemLinks.Add(this.M010203);
            this.m0102.Name = "m0102";
            this.m0102.Text = "Users";
            // 
            // m0103
            // 
            this.m0103.ItemLinks.Add(this.m010301);
            this.m0103.ItemLinks.Add(this.m010302);
            this.m0103.ItemLinks.Add(this.m010303);
            this.m0103.Name = "m0103";
            this.m0103.Text = "General Category";
            // 
            // m0104
            // 
            this.m0104.ItemLinks.Add(this.m010401);
            this.m0104.ItemLinks.Add(this.m010402);
            this.m0104.ItemLinks.Add(this.m010403);
            this.m0104.Name = "m0104";
            this.m0104.Text = "Statics";
            // 
            // m0105
            // 
            this.m0105.ItemLinks.Add(this.m010501);
            this.m0105.ItemLinks.Add(this.m010502);
            this.m0105.ItemLinks.Add(this.m010503);
            this.m0105.Name = "m0105";
            this.m0105.Text = "Employment";
            // 
            // Theme
            // 
            this.Theme.ItemLinks.Add(this.Interface);
            this.Theme.Name = "Theme";
            this.Theme.Text = "Theme";
            // 
            // m02
            // 
            this.m02.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.m02.Name = "m02";
            this.m02.Text = "Help";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "ribbonPageGroup1";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 512);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(897, 31);
            // 
            // Manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 543);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Name = "Manager";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Manager";
            this.Load += new System.EventHandler(this.Manager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage m01;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup m0101;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem M010101;
        private DevExpress.XtraBars.BarButtonItem M010102;
        private DevExpress.XtraBars.BarButtonItem M010103;
        private DevExpress.XtraBars.BarButtonItem M010201;
        private DevExpress.XtraBars.BarButtonItem M010202;
        private DevExpress.XtraBars.BarButtonItem M010203;
        private DevExpress.XtraBars.BarButtonItem m010301;
        private DevExpress.XtraBars.BarButtonItem m010302;
        private DevExpress.XtraBars.BarButtonItem m010303;
        private DevExpress.XtraBars.BarButtonItem m010401;
        private DevExpress.XtraBars.BarButtonItem m010402;
        private DevExpress.XtraBars.BarButtonItem m010403;
        private DevExpress.XtraBars.BarButtonItem m010501;
        private DevExpress.XtraBars.BarButtonItem m010502;
        private DevExpress.XtraBars.BarButtonItem m010503;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup m0102;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup m0103;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup m0104;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup m0105;
        private DevExpress.XtraBars.SkinRibbonGalleryBarItem Change_Interface;
        private DevExpress.XtraBars.SkinRibbonGalleryBarItem Interface;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup Theme;
        private DevExpress.XtraBars.Ribbon.RibbonPage m02;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
    }
}