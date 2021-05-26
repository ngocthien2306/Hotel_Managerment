using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace General_Manager.Form
{
    public partial class PrintList : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public PrintList()
        {
            InitializeComponent();
        }

        private void PrintList_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hotel_ManagementDataSet.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.hotel_ManagementDataSet.Employee);

        }

        private void RibbonControl_SelectedPageChanged(object sender, EventArgs e)
        {
            switch(RibbonControl.SelectedPage.Name)
            {
                case "GridControlPage":
                    DocumentViewer_Employee.Visible = false;
                    GridControl_Data.Visible = true;
                    break;
                case "PreviewRibbonPage":
                    GridControl_Data.Visible = false;
                    DocumentViewer_Employee.Visible = true;
                    printableComponentLink1.CreateDocument();
                    break;
            }
        }
    }
}