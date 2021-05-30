using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace General_Manager.Form
{
    public partial class Customer_history_Form : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        public Customer_history_Form()
        {
            InitializeComponent();
        }

        private void cusHistoryBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cusHistoryBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.hotel_ManagementDataSet);

        }

        private void Customer_history_Form_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hotel_ManagementDataSet.cusHistory' table. You can move, or remove it, as needed.
            this.cusHistoryTableAdapter.Fill(this.hotel_ManagementDataSet.cusHistory);

        }
    }
}
