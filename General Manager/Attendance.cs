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

        private void Checkin_btn_Click(object sender, EventArgs e)
        {
            DateTime checkin = DateTime.Now;
            TimeSpan ts1 = checkin - Convert.ToDateTime(StartTime);
            XtraMessageBox.Show(ts1.ToString());
        }

        private void Checkout_btn_Click(object sender, EventArgs e)
        {
            DateTime checkin = DateTime.Now;
            TimeSpan ts2 = checkin - Convert.ToDateTime(EndTime);
            XtraMessageBox.Show(ts2.ToString());
        }
    }
}