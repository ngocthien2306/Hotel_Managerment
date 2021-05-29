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
    public partial class Attendance : DevExpress.XtraEditors.XtraForm
    {
        WorkShift WS = new WorkShift();
        public string StartTime { get; set; }
        public string EndTime { get; set; }

        public Attendance()
        {
            InitializeComponent();
        }

        private void Attendance_Load(object sender, EventArgs e)
        {
            ID_tb.Text = (Login.CurrentID).ToString();
            timer.Start();
            LoadTime();
        }

        public void LoadTime()
        {
            int id = Convert.ToInt32((Login.CurrentID).ToString()) ;
            DataTable dt = new DataTable();
            dt = WS.WorkTime(id);
            Start_tb.Text = dt.Rows[0][0].ToString();
            End_tb.Text = dt.Rows[0][1].ToString();
            StartTime = dt.Rows[0][0].ToString();
            EndTime = dt.Rows[0][1].ToString();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            Date_tb.Text = DateTime.Now.ToString("dd/MM/yyyy");
            Time_tb.Text = DateTime.Now.ToString("H:mm tt");
        }


        private void CheckIn_btn_Click_1(object sender, EventArgs e)
        {
            DateTime checkin = DateTime.Now;
            TimeSpan ts1 = checkin - Convert.ToDateTime(StartTime);
            int iduration = Convert.ToInt32(ts1.TotalMinutes);
            if ( iduration < 0 )
            {
                XtraMessageBox.Show("Your workshift hasn't started yet! ");
            }
            else
            {
                XtraMessageBox.Show("You are " + iduration.ToString() + " late");
            }
        }

        private void CheckOut_btn_Click_1(object sender, EventArgs e)
        {
            DateTime checkout = DateTime.Now;
            TimeSpan ts2 = checkout - Convert.ToDateTime(EndTime);
            int oduration = Convert.ToInt32(ts2.TotalMinutes);
            if (oduration < 0)
            {
                XtraMessageBox.Show("Your workshift hasn't ended yet! [" + oduration.ToString() +" ] soon");
            }
            else
            {
                XtraMessageBox.Show("Thanks for working hard today");
            }
        }
    }
}