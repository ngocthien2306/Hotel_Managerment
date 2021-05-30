using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace General_Manager.Form
{
    class User
    {
        public int ID { get; set; }
        public string Fullname { get; set; }
        public DateTime Birthday { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public MemoryStream Picture { get; set; }
        public int CMND { get; set; }

        static Database connect = new Database();
        public bool GetUser(string user, string pass)
        {
            SqlCommand command = new SqlCommand("INSERT INTO Login (Username, Password) + VALUES (@user, @pass)", connect.GetConnection);
            command.Parameters.Add(@"user", SqlDbType.NVarChar).Value = user;
            command.Parameters.Add(@"pass", SqlDbType.NVarChar).Value = pass;
            connect.OpenConnection();
            if (command.ExecuteNonQuery() == 1)
            {
                return true;
            }
            else
            {
                connect.CloseConnection();
                return false;
            }
        }
        public DataTable GetUser(SqlCommand command)
        {
            command.Connection = connect.GetConnection;
            SqlDataAdapter SDA = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            SDA.Fill(table);
            return table;
        }
        Database data = new Database();
        public DataTable GetUserByID(Int32 userid)
        {

            SqlDataAdapter SDA = new SqlDataAdapter();
            DataTable table = new DataTable();
            SqlCommand command = new SqlCommand("SELECT * FROM New_User WHERE Id = @id", data.GetConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = userid;
            SDA.SelectCommand = command;
            SDA.Fill(table);
            return table;
        }
        public bool UserNameExist(string username, string operation, int userid = 0)
        {
            string query = "";
            if (operation == "register")
            {
                query = "SELECT * FROM New_User WHERE username = @un";
            }
            else if (operation == "edit")
            {
                query = "SELECT * FROM New_User WHERE username = @un and Id <> @id";
            }
            SqlCommand command = new SqlCommand(query, data.GetConnection);
            command.Parameters.Add("@un", SqlDbType.NVarChar).Value = username;
            command.Parameters.Add("@id", SqlDbType.Int).Value = userid;
            SqlDataAdapter SDA = new SqlDataAdapter();
            DataTable table = new DataTable();
            SDA.SelectCommand = command;
            SDA.Fill(table);
            data.OpenConnection();
            if (table.Rows.Count > 0)
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
        public bool Login(string user, string pass)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM Customer where username = @user AND password = @pass", connect.GetConnection);
            command.Parameters.Add("@user", SqlDbType.NVarChar).Value = user;
            command.Parameters.Add("@pass", SqlDbType.NVarChar).Value = pass;
            SqlDataAdapter SDA = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            SDA.Fill(table);
            if (table.Rows.Count > 0)
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
        public DateTimeOffset DayLog { get; set; }
        public string Description { get; set; }
        public bool SaveHistoryLogin()
        {
            try
            {
                Database data = new Database();
                SqlCommand conmmand = new SqlCommand("INSERT INTO cusHistory (fullname, username, daylog, description)" +
                    "VALUES (@full, @user, @day, @des)", data.GetConnection);
                conmmand.Parameters.Add(@"full", SqlDbType.NVarChar).Value = Fullname;
                conmmand.Parameters.Add("@user", SqlDbType.NVarChar).Value = Username;
                conmmand.Parameters.Add("@day", SqlDbType.DateTimeOffset).Value = DayLog;
                conmmand.Parameters.Add("@des", SqlDbType.Text).Value = Description;

                data.OpenConnection();
                if (conmmand.ExecuteNonQuery() == 1)
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
            catch (Exception a)
            {
                XtraMessageBox.Show(a.Message);
                return false;
            }
        }
        public bool Insert_User(int id, string full, MemoryStream pic, DateTime bday, string password, string username, int cmnd)
        {
            Database data = new Database();
            SqlCommand command = new SqlCommand("INSERT INTO Customer (Id, fullname, picture, birthday, password, username, CMND)" +
                "VALUES (@ID, @fname, @pic, @day, @pass, @user, @cmnd)", data.GetConnection);
            command.Parameters.Add("@ID", SqlDbType.Int).Value = id;
            command.Parameters.Add("@fname", SqlDbType.NChar).Value = full;
            command.Parameters.Add("@pic", SqlDbType.Image).Value = pic.ToArray();
            command.Parameters.Add("@day", SqlDbType.Date).Value = bday;
            command.Parameters.Add("@pass", SqlDbType.NChar).Value = password;
            command.Parameters.Add("@user", SqlDbType.NVarChar).Value = username;
            command.Parameters.Add("@cmnd", SqlDbType.Int).Value = cmnd;
            data.OpenConnection();
            if (command.ExecuteNonQuery() == 1)
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
    }
}
