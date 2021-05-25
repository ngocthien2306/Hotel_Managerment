using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace General_Manager.Form
{
    class WorkShift
    {
        Database db = new Database();

        public DataTable WorkTime(int Id)
        {
            SqlCommand cmd = new SqlCommand("Select stime,etime from WorkShift where Id = " +Id, db.GetConnection);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }

    }
}
