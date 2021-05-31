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
        DataTable dt;
        public void LoadTime()
        {
            int id = Convert.ToInt32((Login.CurrentID).ToString()) ;
            dt = new DataTable();
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
            int duration = Convert.ToInt32(ts1.TotalMinutes);
            XtraMessageBox.Show(duration.ToString());
            EmployeeHotel em = new EmployeeHotel();
            Menu menu = new Menu();
            em.ID = Convert.ToInt32(menu.Label_ShowId.Text);
            em.Description = "Check in " + DateTime.Now.ToString();
            em.SaveHistoryCheckINandOut();
        }

        private void CheckOut_btn_Click_1(object sender, EventArgs e)
        {
            DateTime checkin = DateTime.Now;
            TimeSpan ts2 = checkin - Convert.ToDateTime(EndTime);
            int duration = Convert.ToInt32(ts2.TotalMinutes);
            XtraMessageBox.Show(duration.ToString());
            EmployeeHotel em = new EmployeeHotel();
            Menu menu = new Menu();
            em.ID = Convert.ToInt32(menu.Label_ShowId.Text);
            em.Description = "Check out " + DateTime.Now.ToString();
            em.SaveHistoryCheckINandOut();
        }
    }
}