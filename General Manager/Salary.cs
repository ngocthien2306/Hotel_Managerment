using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace General_Manager.Form
{
    class Salary
    {
        Database db = new Database();

        public DataTable SalaryPerDay()
        {
            string DoW = DateTime.Now.ToString("dddd");
            SqlCommand cmd = new SqlCommand("select Id,role,"+DoW+" from SalaryPerDay where "+ DoW + " > 0", db.GetConnection);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            return dt;
        }
    }
}
