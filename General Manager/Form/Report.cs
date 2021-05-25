using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.IO;

namespace General_Manager.Form
{
    public partial class Report : DevExpress.XtraReports.UI.XtraReport
    {
        public Report()
        {
            InitializeComponent();
        }
        public void InitData(int id, string fname, string lname, int cmmnd, DateTime bday, string address, string phone, string email, int salary, MemoryStream picutre )
        {
            
        }
    }
}
