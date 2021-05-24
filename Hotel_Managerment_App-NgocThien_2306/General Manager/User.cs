using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.IO;
using System.Drawing;
using System.Windows.Forms;

namespace General_Manager.Form
{
    class User
    {
        
        public string Username { get; set; }
        public int Password { get; set; }
        public User(string user = "", int pass = 0)
        {
            this.Username = user;
            this.Password = pass;
        }
        My_Database data = new My_Database();
        public bool AddUsers(string user, int pass)
        {
            try 
            {
                SqlCommand conmmand = new SqlCommand("INSERT INTO Login (Username, Password)" + "VALUES (@user, @pass)", data.GetConnection);
                conmmand.Parameters.Add(@"user", SqlDbType.NVarChar).Value = user;
                conmmand.Parameters.Add("@pass", SqlDbType.NVarChar).Value = pass;
                data.OpenConnection();
                if(conmmand.ExecuteNonQuery() == 1)
                {
                    data.CloseConnection();
                    return true;
                }
                else
                {
                    data.CloseConnection();
                    return false;
                }
            }
            catch(Exception a)
            {
                MessageBox.Show(a.Message);
                return false;
            }
        }
        public DataTable GetUsers(SqlCommand command)
        {
            command.Connection = data.GetConnection;
            SqlDataAdapter SDA = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            SDA.Fill(table);
            return table;
        }
    }
}
