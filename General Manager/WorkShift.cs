using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using DevExpress.XtraEditors;

namespace General_Manager.Form
{
    class WorkShift
    {
        Database db = new Database(); 
       
             
        public bool InsertId(int id)
        {
            SqlCommand command = new SqlCommand("Insert into WorkShift (Id) VALUES (@ID)", db.GetConnection);
            command.Parameters.Add("@ID", SqlDbType.Int).Value = id;
            db.OpenConnection();
            if(command.ExecuteNonQuery() == 1)
            {
                db.CloseConnection();
                return true;              
            }
            else
            {
                db.CloseConnection();
                return false;
            }
        }
        public DataTable Showfull()
        {
            Database data = new Database();
            SqlCommand command = new SqlCommand();
            command.Connection = data.GetConnection;
            command.CommandText = "Select monday, tuesday, wednesday thusday, friday, satusday, sunday from Schedule";
            SqlDataAdapter SDA = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            SDA.Fill(table);
            return table;
        }
        public DataTable Show()
        {
            Database data = new Database();
            SqlCommand command = new SqlCommand();
            command.Connection = data.GetConnection;
            command.CommandText = "Select id from Schedule";
            SqlDataAdapter SDA = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            SDA.Fill(table);
            return table;
        }
        public int ReturnShiftManager()
        {
            try
            {
                Database data = new Database();
                SqlCommand command = new SqlCommand(@"Select count(*) from employee where role = 'Manager'", data.GetConnection);
                data.OpenConnection();
                command.CommandText = @"Select count(*) from employee where role = 'Manager'";
                return (int)command.ExecuteScalar();
            }
            catch
            {
                return 0;
            }
        }
        public void GetIdEmployee()
        {
            DataTable table = this.Show();
            EmployeeHotel employee = new EmployeeHotel();
            int[] ID = new int[20];
            int[] Shirt = new int[20];
            int id;
            int count = 0;
            int total = Convert.ToInt32(employee.GetNumberJanior()) + Convert.ToInt32(employee.GetNumberOfManager()) + Convert.ToInt32(employee.GetNumberReceptionist());
            for (int i = 0; i < total; i++)
            {
                id = Convert.ToInt32(table.Rows[i]["id"].ToString().Trim());
                ID[i] = id;               
            }
            int index = 0;
            Random ran = new Random();
            for (int i = 0; i < 20; i++)
            {
                int ch1 = ran.Next(1, 4);
                int ch2 = ran.Next(1, 4);
                int ch3 = ran.Next(1, 4);
                int ch4 = ran.Next(1, 4);
                int ch5 = ran.Next(1, 4);
                int ch6 = ran.Next(1, 4);
                int ch7 = ran.Next(1, 4);
                this.UppdateShift(ch1, ch2, ch3, ch4, ch5, ch6, ch7, ID[index++]);
            }
            DataTable table1 = this.Showfull();
            for (int i = 0; i < total; i++)
            {
                int m = Convert.ToInt32(table1.Rows[i]["monday"].ToString().Trim());
                if (m == 1)
                {
                    count += count;
                }
                Shirt[0] = count;
            }
        }
        public void GetShift()
        {
            //EmployeeHotel employee = new EmployeeHotel();
            //int manager = Convert.ToInt32(employee.GetNumberOfManager());
            //int receptionist = Convert.ToInt32(employee.GetNumberReceptionist());
            //int janior = Convert.ToInt32(employee.GetNumberJanior());

        }
        public bool DeleteData()
        {
            Database data = new Database();
            SqlCommand command = new SqlCommand("delete from Schedule", data.GetConnection);
            data.OpenConnection();
            if (command.ExecuteNonQuery() > 0)
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
        public bool InsertShift()
        {
            Database data = new Database();
            SqlCommand command = new SqlCommand("insert into Schedule (Id, firstname, lastname, role) select Id, fname, lname, role from Employee", data.GetConnection);
            data.OpenConnection();
            if (command.ExecuteNonQuery() > 0)
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
        public bool UppdateShift(int shiftmon, int shifttu, int shiftwed, int shiftthus, int shiftfri, int shiftsat, int shiftsun, int id)
        {
            Database data = new Database();
            SqlCommand command = new SqlCommand("Update Schedule SET monday = @mon, tuesday = @tu, wednesday = @wed, thusday = @thus, friday = @fri, satusday = @sat, sunday = @sun Where Id = @id", data.GetConnection);
            command.Parameters.Add("@mon", SqlDbType.Int).Value = shiftmon;
            command.Parameters.Add("@tu", SqlDbType.Int).Value = shifttu;
            command.Parameters.Add("@wed", SqlDbType.Int).Value = shiftwed;
            command.Parameters.Add("@thus", SqlDbType.Int).Value = shiftthus;
            command.Parameters.Add("@fri", SqlDbType.Int).Value = shiftfri;
            command.Parameters.Add("@sat", SqlDbType.Int).Value = shiftsat;
            command.Parameters.Add("@sun", SqlDbType.Int).Value = shiftsun;
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            data.OpenConnection();
            if(command.ExecuteNonQuery() > 0)
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
        public DataTable ShowShift()
        {
            Database data = new Database();
            SqlCommand command = new SqlCommand();
            data.OpenConnection();
            command.Connection = data.GetConnection;
            command.CommandText = "Select id, firstname, lastname, role, monday, tuesday, wednesday, thusday, friday, satusday, sunday from Schedule";
            SqlDataAdapter SDA = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            SDA.Fill(table);
            return table;
        }
        public DataTable ShowReloadShift()
        {
            DataTable table = new DataTable();
            Database data = new Database();
            try
            {
                this.GetIdEmployee();
                SqlCommand command = new SqlCommand();
                data.OpenConnection();
                command.Connection = data.GetConnection;
                command.CommandText = "Select id, firstname, lastname, role, monday, tuesday, wednesday, thusday, friday, satusday, sunday from Schedule";
                SqlDataAdapter SDA = new SqlDataAdapter(command);
                SDA.Fill(table);
                return table;
            }
            catch
            {
                return table;
            }
        }
        public DataTable WorkTime(int Id)
        {
            SqlCommand cmd = new SqlCommand("Select stime, etime from WorkShift where Id = " +Id, db.GetConnection);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }

    }
}
