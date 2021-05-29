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
    public partial class Display_User : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public Display_User()
        {
            InitializeComponent();
        }

        private void Watch_Load(object sender, EventArgs e)
        {

        }

        private void customerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.customerBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.hotel_ManagementDataSet1);

        }

        private void Display_User_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hotel_ManagementDataSet1.Customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.hotel_ManagementDataSet1.Customer);

        }
    }
}