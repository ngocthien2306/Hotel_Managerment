﻿using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraScheduler;

namespace General_Manager.Form
{
    public partial class Salary_Perday : DevExpress.XtraEditors.XtraForm
    {
        public Salary_Perday()
        {
            InitializeComponent();
        }

        private void Salary_Perday_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hotel_ManagementDataSet.empHistory' table. You can move, or remove it, as needed.
            this.empHistoryTableAdapter.Fill(this.hotel_ManagementDataSet.empHistory);

        }
    }
}