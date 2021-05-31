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
using DevExpress.XtraEditors;

namespace General_Manager.Form
{
    class EmployeeHotel
    {
        
        public int ID { get; set; }
        public string Password { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public int CMND { get; set; }
        public DateTime Birthday { get; set; }
        public string Address { get; set; }
        public int Phone { get; set; }
        public string Email { get; set; }
        public string Gender { get; set; }
        public double Salary { get; set; }
        public string Role { get; set; }
        public int Daywork { get; set; }
        public int Work { get; set; }
        public MemoryStream Picture { get; set; }
        public EmployeeHotel(int id = 0, string pass = "", string fname = "", string lname = "", int cmnd = 0, DateTime bday = default, string address = "",
           int phone = 0, string email = "", string gender = "", double salary = 0, string role = "", int daywork = 0, int work = 0, MemoryStream picture = null)
        {
            this.ID = id;
            this.Password = pass;
            this.Firstname = fname;
            this.Lastname = lname;
            this.CMND = cmnd;
            this.Birthday = bday;
            this.Address = address;
            this.Phone = phone;
            this.Email = email;
            this.Gender = gender;
            this.Salary = salary;
            this.Role = role;
            this.Daywork = daywork;
            this.Work = work;
            this.Picture = picture;
        }
        public object GetNumberOfManager()
        {
            try
            {
                Database data = new Database();
                SqlCommand command = new SqlCommand(@"Select count(*) from employee where role = 'Manager'", data.GetConnection);
                data.OpenConnection();
                command.CommandText = @"Select count(*) from employee where role = 'Manager'";
                return command.ExecuteScalar();
            }
            catch
            {
                return false;
            }
        }
        public object GetNumberReceptionist()
        {
            try
            {
                Database data = new Database();
                SqlCommand command = new SqlCommand(@"Select count(*) from employee where role = 'Receptionist'", data.GetConnection);
                data.OpenConnection();
                command.CommandText = @"Select count(*) from employee where role = 'Receptionist'";
                return command.ExecuteScalar();
            }
            catch
            {
                return false;
            }
        }
        public string Fullname { get; set; }
        public DateTimeOffset Daylog { get; set; }
        public string Description { get; set; }
        public bool SaveHistoryCheckINandOut()
        {
            try
            {
                Database data = new Database();
                SqlCommand command = new SqlCommand("INSERT INTO empHistory (Id, description) VALUES (@id, @des)", data.GetConnection);
                command.Parameters.Add("@des", SqlDbType.Text).Value = Description;
                command.Parameters.Add("@id", SqlDbType.Int).Value = ID;
                data.OpenConnection();
                if(command.ExecuteNonQuery() == 1)
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
                XtraMessageBox.Show(a.Message);
                return false;
            }
        }
        public bool DeleteHistory()
        {
            try
            {
                Database data = new Database();
                SqlCommand conmmand = new SqlCommand("delete from empHistory", data.GetConnection);
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
        public bool SaveHistoryLogin() {
            try
            {
                Database data = new Database();
                SqlCommand conmmand = new SqlCommand("INSERT INTO empHistory (Id, fullname, daylog, role, description)" +
                    "VALUES (@id, @full, @day, @role, @des)", data.GetConnection);
                conmmand.Parameters.Add(@"id", SqlDbType.Int).Value = ID;
                conmmand.Parameters.Add("@full", SqlDbType.NVarChar).Value = Fullname;
                conmmand.Parameters.Add("@day", SqlDbType.DateTimeOffset).Value = Daylog;
                conmmand.Parameters.Add("@role", SqlDbType.NVarChar).Value = Role;
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
        public object GetNumberJanitor()
        {
            try
            {
                Database data = new Database();
                SqlCommand command = new SqlCommand(@"Select count(*) from employee where role = 'Janitor'", data.GetConnection);
                data.OpenConnection();
                command.CommandText = @"Select count(*) from employee where role = 'Janitor'";
                return command.ExecuteScalar();
            }
            catch
            {
                return false;
            }
        }
        public bool GetLogin()
        {
            try
            {
                Database data = new Database();
                SqlCommand command = new SqlCommand("SELECT * FROM Employee where Id = @user AND password = @pass", data.GetConnection);
                command.Parameters.Add("@user", SqlDbType.NVarChar).Value = ID;
                command.Parameters.Add("@pass", SqlDbType.NVarChar).Value = Password;
                SqlDataAdapter SDA = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                SDA.Fill(table);
                if (table.Rows.Count > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }
        public bool AddUsers()
        {
            try 
            {
                Database data = new Database();
                SqlCommand conmmand = new SqlCommand("INSERT INTO Employee (Id, password,fname, lastname, CMND, bdate, address, phone, email, role, picture, gender)" + 
                    "VALUES (@id, @pass, @fn, @ln, @cmnd, @day, @add, @ph, @em, @ro, @pic, @gen)", data.GetConnection);
                conmmand.Parameters.Add(@"id", SqlDbType.Int).Value = ID;
                conmmand.Parameters.Add("@pass", SqlDbType.NVarChar).Value = Password;
                conmmand.Parameters.Add("@ln", SqlDbType.NVarChar).Value = Lastname;
                conmmand.Parameters.Add("@fn", SqlDbType.NVarChar).Value = Firstname;
                conmmand.Parameters.Add("@cmnd", SqlDbType.Int).Value = CMND;
                conmmand.Parameters.Add("@day", SqlDbType.DateTime).Value = Birthday;
                conmmand.Parameters.Add("@add", SqlDbType.NVarChar).Value = Address;
                conmmand.Parameters.Add("@ph", SqlDbType.Int).Value = Phone;
                conmmand.Parameters.Add("@em", SqlDbType.NVarChar).Value = Email;
                conmmand.Parameters.Add("@ro", SqlDbType.NVarChar).Value = Role;
                conmmand.Parameters.Add("@pic", SqlDbType.Image).Value = Picture.ToArray();
                conmmand.Parameters.Add("@gen", SqlDbType.NVarChar).Value = Role;
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
                XtraMessageBox.Show(a.Message);
                return false;
            }
        }
        public DataTable GetUsers(SqlCommand command)
        {
            Database data = new Database();
            command.Connection = data.GetConnection;
            SqlDataAdapter SDA = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            SDA.Fill(table);
            return table;
        }
    }
}
