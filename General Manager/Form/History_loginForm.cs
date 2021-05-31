using DevExpress.XtraBars;
using DevExpress.XtraEditors;
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

        private void HistoryDelete_btn_Click(object sender, EventArgs e)
        {
            EmployeeHotel em = new EmployeeHotel();
            DialogResult delete = XtraMessageBox.Show("Are you sure delete the list of the history login", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(delete == DialogResult.Yes)
            {
                em.DeleteHistory();
            }

        }

        private void Printlist_btn_Click(object sender, EventArgs e)
        {
            gridView1.ShowPrintPreview();
        }

        private void Find_btn_Click(object sender, EventArgs e)
        {
            gridView1.OptionsFind.AlwaysVisible = true;
            gridView1.OptionsView.ShowPreview = true;
        }

        private void Reload_btn_Click(object sender, EventArgs e)
        {
            this.empHistoryTableAdapter.Fill(this.hotel_ManagementDataSet.empHistory);
        }
    }
}
