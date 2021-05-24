using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace General_Manager.Form
{
    class My_Database
    {
        SqlConnection connect = new SqlConnection(@"Data Source=DESKTOP-US6D43H;Initial Catalog=Hotel_Managerment;Integrated Security=True");
        public SqlConnection GetConnection
        {
            get { return this.connect; }
        }
        public void OpenConnection()
        {
            if(connect.State == ConnectionState.Closed)
            {
                connect.Open();
            }
        }
        public void CloseConnection()
        {
            if(connect.State == ConnectionState.Open)
            {
                connect.Close();
            }
        }
    }
}
