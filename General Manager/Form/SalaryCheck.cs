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
using System.Data.SqlClient;

namespace General_Manager.Form
{
    public partial class SalaryCheck : DevExpress.XtraEditors.XtraForm
    {
        public SalaryCheck()
        {
            InitializeComponent();
        }

        private void SalaryCheck_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hotel_ManagementDataSet.empHistory' table. You can move, or remove it, as needed.
            //this.empHistoryTableAdapter.Fill(this.hotel_ManagementDataSet.empHistory);
            EmployeeHotel employee = new EmployeeHotel();
            int id = (Login.CurrentID);
            Label_showid.Text = Convert.ToString(id);
            Database data = new Database();
            SqlCommand command = new SqlCommand("select description from empHistory where Id = @id ", data.GetConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            Treelist_History.DataSource = employee.GetUsers(command);
        }

        private void Buton_checkSalaryperday_Click(object sender, EventArgs e)
        {
            Salary salarycheck = new Salary();
            DataTable table = salarycheck.SalaryPerDay();
            string DoW = DateTime.Now.ToString("dddd");
            string salary = table.Rows[0][DoW].ToString().Trim() + " VND ";
            ShowSalary_tb.Text = salary;
        }
    }
}