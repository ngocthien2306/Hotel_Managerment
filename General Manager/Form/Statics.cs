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
    public partial class Statics : DevExpress.XtraEditors.XtraForm
    {
        public Statics()
        {
            InitializeComponent();
        }

        private void Statics_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hotel_ManagementDataSet.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.hotel_ManagementDataSet.Employee);

        }
    }
}