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
    public partial class History_loginForm : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        public History_loginForm()
        {
            InitializeComponent();
        }

        private void empHistoryBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.empHistoryBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.hotel_ManagementDataSet);

        }

        private void History_loginForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hotel_ManagementDataSet.empHistory' table. You can move, or remove it, as needed.
            this.empHistoryTableAdapter.Fill(this.hotel_ManagementDataSet.empHistory);

        }
    }
}
