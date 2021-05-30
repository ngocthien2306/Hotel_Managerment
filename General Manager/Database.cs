using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace General_Manager.Form
{
    class Database
    {
        //"Data Source=DESKTOP-A1KBTCS;Initial Catalog=Hotel Management;Integrated Security=True"
        //"Data Source=DESKTOP-NHHG86O;Initial Catalog=Hotel Management;Integrated Security=True"
        SqlConnection connect = new SqlConnection(@"Data Source=DESKTOP-A1KBTCS;Initial Catalog=Hotel Management;Integrated Security=True");
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
