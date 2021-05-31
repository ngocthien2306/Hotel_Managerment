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
        EmployeeHotel em = new EmployeeHotel();
        Menu menu = new Menu();

        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public string WorkStart { get; set; }
        public string WorkEnd { get; set; }

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
            int id = Convert.ToInt32((Login.CurrentID).ToString());
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
            //XtraMessageBox.Show(duration.ToString());  
            if (duration < 0 )
            {
                {
                    XtraMessageBox.Show("Your shift hasn't started yet");
                }
            }
            else
            {
                DialogResult CheckInCheck = XtraMessageBox.Show("Do you want to check-in now?", "Check in", MessageBoxButtons.YesNo);
                if (CheckInCheck == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(ID_tb.Text);
                    em.Description = "Checked in at " + DateTime.Now.ToString("MM/dd/YYYY");
                    em.SaveHistoryCheckINandOut(id);
                    WorkStart = DateTime.Now.ToString("MM/dd/yyyy hh:mm:ss tt");
                }
                else
                {
            
                }
            }
        }

        private void CheckOut_btn_Click_1(object sender, EventArgs e)
        {
            DateTime checkout = DateTime.Now;  
            TimeSpan ts2 = checkout - Convert.ToDateTime(EndTime);
            int duration = Convert.ToInt32(ts2.TotalMinutes);
            if (duration < 0)
            {
                DialogResult SoonCheckOut = XtraMessageBox.Show("Your shift hasn't ended yet! Are you sure?", "Check out", MessageBoxButtons.YesNo);
                if (SoonCheckOut == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(ID_tb.Text);
                    em.Description = "Checked out at " + DateTime.Now.ToString("MM/dd/YYYY");
                    em.SaveHistoryCheckINandOut(id);
                    WorkEnd = DateTime.Now.ToString("MM/dd/yyyy hh:mm:ss tt");
                    TimeSpan WD = Convert.ToDateTime(WorkEnd) - Convert.ToDateTime(WorkStart);
                    int WorkM = Convert.ToInt32(WD.TotalMinutes);
                    WS.UpdateWorkDuration(id, WorkM);
                }
                else
                {
            
                }
            }
            else
            {
                DialogResult CheckOutCheck = XtraMessageBox.Show("Do you want to check-out now?", "Check out", MessageBoxButtons.YesNo);
                if (CheckOutCheck == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(ID_tb.Text);
                    em.Description = "Checked out at" + DateTime.Now.ToString("MM/dd/YYYY");
                    em.SaveHistoryCheckINandOut(id);
                    WorkStart = DateTime.Now.ToString("MM/dd/yyyy hh:mm:ss tt");
                    TimeSpan WD = Convert.ToDateTime(WorkEnd) - Convert.ToDateTime(WorkStart);
                    int WorkM = Convert.ToInt32(WD.TotalMinutes); 
                    WS.UpdateWorkDuration(id, WorkM);
                }
                else
                {
             
                }
            }
        }
    }
}