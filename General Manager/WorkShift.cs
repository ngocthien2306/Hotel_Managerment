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
        public int[] arrayID = new int[20];
        public string[] arrayRole = new string[20];
        Random random = new Random();
        public int Check { get; set; }
        public int Total { get; set; }
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
        public DataTable ShowId()
        {
            Database data = new Database();
            SqlCommand command = new SqlCommand();
            command.Connection = data.GetConnection;
            command.CommandText = "Select id, role from Schedule";
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
        public void ReLoad()
        {
            DataTable table = this.ShowId();
            EmployeeHotel employee = new EmployeeHotel();
            Random random = new Random();
            Total = Convert.ToInt32(employee.GetNumberJanior()) + Convert.ToInt32(employee.GetNumberOfManager()) + Convert.ToInt32(employee.GetNumberReceptionist());
            this.ReturnRoleID();
            for (int i = 0; i < Total; i++)
            {
                int mon = random.Next(1, 4);
                int tue = random.Next(1, 4);
                int wed = random.Next(1, 4);
                int thu = random.Next(1, 4);
                int fri = random.Next(1, 4);
                this.UppdateShiftColumn1(arrayID[i], mon);
                this.UppdateShiftColumn2(arrayID[i], tue);
                this.UppdateShiftColumn3(arrayID[i], wed);
                this.UppdateShiftColumn4(arrayID[i], thu);
                this.UppdateShiftColumn5(arrayID[i], fri);
            }
        }

        public void ReturnRoleID()
        {
            DataTable table = this.ShowId();
            EmployeeHotel employee = new EmployeeHotel();
            Total = Convert.ToInt32(employee.GetNumberJanior()) + Convert.ToInt32(employee.GetNumberOfManager()) + Convert.ToInt32(employee.GetNumberReceptionist());
            for (int i = 0; i < Total; i++)
            {
                arrayRole[i] = table.Rows[i]["role"].ToString().Trim();
                arrayID[i] = Convert.ToInt32(table.Rows[i]["id"].ToString().Trim());
            }
        }
        public void GetShift()
        {
            this.ReturnRoleID();
            EmployeeHotel employee = new EmployeeHotel();
            int manager = 5 * Convert.ToInt32(employee.GetNumberOfManager());
            int receptionist = 4 * Convert.ToInt32(employee.GetNumberReceptionist());
            int janior =  6* Convert.ToInt32(employee.GetNumberJanior());
            //Monday
            for (int i = 0; i < Total; i++)
            {
                if (arrayRole[i] == "Manager" && manager > 0)
                {
                    Check = 0;
                    int s1 = random.Next(1, 4);
                    if (Check != s1)
                    {
                        this.UppdateShiftColumn1(arrayID[i], s1);
                    }
                    Check = s1;
                    manager--;
                }
            }
            for (int i = 0; i < Total; i++)
            {
                if (arrayRole[i] == "Receptionist" && receptionist > 0)
                {
                    int s1 = random.Next(1, 4);
                    if (Check != s1)
                    {
                        this.UppdateShiftColumn1(arrayID[i], s1);
                    }
                    Check = s1;
                    receptionist--;
                }
            }
            for (int i = 0; i < Total; i++)
            {
                if (arrayRole[i] == "Janior" && janior > 0)
                {
                    int s1 = random.Next(1, 4);
                    if (Check != s1)
                    {
                        this.UppdateShiftColumn1(arrayID[i], s1);
                    }
                    Check = s1;
                    janior--;
                }
            }
            //Tuesday
            for (int i = 0; i < Total; i++)
            {
                if (arrayRole[i] == "Manager" && manager > 0)
                {
                    Check = 0;
                    int s1 = random.Next(1, 4);
                    if (Check != s1)
                    {
                        this.UppdateShiftColumn2(arrayID[i], s1);
                    }
                    Check = s1;
                    manager--;
                }
            }
            for (int i = 0; i < Total; i++)
            {
                if (arrayRole[i] == "Receptionist" && receptionist > 0)
                {
                    int s1 = random.Next(1, 4);
                    if (Check != s1)
                    {
                        this.UppdateShiftColumn2(arrayID[i], s1);
                    }
                    Check = s1;
                    receptionist--;
                }
            }
            for (int i = 0; i < Total; i++)
            {
                if (arrayRole[i] == "Janior" && janior > 0)
                {
                    int s1 = random.Next(1, 4);
                    if (Check != s1)
                    {
                        this.UppdateShiftColumn2(arrayID[i], s1);
                    }
                    Check = s1;
                    janior--;
                }
            }

            //Wednesday
            for (int i = 0; i < Total; i++)
            {
                if (arrayRole[i] == "Manager" && manager > 0)
                {
                    Check = 0;
                    int s1 = random.Next(1, 4);
                    if (Check != s1)
                    {
                        this.UppdateShiftColumn3(arrayID[i], s1);
                    }
                    Check = s1;
                    manager--;
                }
            }
            for (int i = 0; i < Total; i++)
            {
                if (arrayRole[i] == "Receptionist" && receptionist > 0)
                {
                    int s1 = random.Next(1, 4);
                    if (Check != s1)
                    {
                        this.UppdateShiftColumn3(arrayID[i], s1);
                    }
                    Check = s1;
                    receptionist--;
                }
            }
            for (int i = 0; i < Total; i++)
            {
                if (arrayRole[i] == "Janior" && janior > 0)
                {
                    int s1 = random.Next(1, 4);
                    if (Check != s1)
                    {
                        this.UppdateShiftColumn3(arrayID[i], s1);
                    }
                    Check = s1;
                    janior--;
                }
            }
            //Thusday
            for (int i = 0; i < Total; i++)
            {
                if (arrayRole[i] == "Manager" && manager > 0)
                {
                    Check = 0;
                    int s1 = random.Next(1, 4);
                    if (Check != s1)
                    {
                        this.UppdateShiftColumn4(arrayID[i], s1);
                    }
                    Check = s1;
                    manager--;
                }
            }
            for (int i = 0; i < Total; i++)
            {
                if (arrayRole[i] == "Receptionist" && receptionist > 0)
                {
                    int s1 = random.Next(1, 4);
                    if (Check != s1)
                    {
                        this.UppdateShiftColumn4(arrayID[i], s1);
                    }
                    Check = s1;
                    receptionist--;
                }
            }
            for (int i = 0; i < Total; i++)
            {
                if (arrayRole[i] == "Janior" && janior > 0)
                {
                    int s1 = random.Next(1, 4);
                    if (Check != s1)
                    {
                        this.UppdateShiftColumn4(arrayID[i], s1);
                    }
                    Check = s1;
                    janior--;
                }
            }
            //Friday
            for (int i = 0; i < Total; i++)
            {
                if (arrayRole[i] == "Manager" && manager > 0)
                {
                    Check = 0;
                    int s1 = random.Next(1, 4);
                    if (Check != s1)
                    {
                        this.UppdateShiftColumn5(arrayID[i], s1);
                    }
                    Check = s1;
                    manager--;
                }
            }
            for (int i = 0; i < Total; i++)
            {
                if (arrayRole[i] == "Receptionist" && receptionist > 0)
                {
                    int s1 = random.Next(1, 4);
                    if (Check != s1)
                    {
                        this.UppdateShiftColumn5(arrayID[i], s1);
                    }
                    Check = s1;
                    receptionist--;
                }
            }
            for (int i = 0; i < Total; i++)
            {
                if (arrayRole[i] == "Janior" && janior > 0)
                {
                    int s1 = random.Next(1, 4);
                    if (Check != s1)
                    {
                        this.UppdateShiftColumn5(arrayID[i], s1);
                    }
                    Check = s1;
                    janior--;
                }
            }
            //for (int i = 0; i < Total; i++)
            //{
            //    int mon = random.Next(1, 4);
            //    int tue = random.Next(1, 4);
            //    int wed = random.Next(1, 4);
            //    int thu = random.Next(1, 4);
            //    int fri = random.Next(1, 4);
            //    int sat = random.Next(1, 4);
            //    int sun = random.Next(1, 4);
            //    this.UppdateShift(arrayID[i], mon, tue, wed, thu, fri, sat, sun);
            //}


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
        public bool UppdateShift(int id, int shiftmon, int shifttu, int shiftwed, int shiftthus, int shiftfri, int shiftsat, int shiftsun)
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
        public bool UppdateShiftColumn2(int id, int shifttu)
        {
            Database data = new Database();
            SqlCommand command = new SqlCommand("Update Schedule SET tuesday = @tu Where Id = @id", data.GetConnection);
            command.Parameters.Add("@tu", SqlDbType.Int).Value = shifttu;
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
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
        public bool UppdateShiftColumn1(int id, int shiftmon)
        {
            Database data = new Database();
            SqlCommand command = new SqlCommand("Update Schedule SET monday = @mon Where Id = @id", data.GetConnection);
            command.Parameters.Add("@mon", SqlDbType.Int).Value = shiftmon;
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
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
        public bool UppdateShiftColumn3(int id, int shiftwed)
        {
            Database data = new Database();
            SqlCommand command = new SqlCommand("Update Schedule SET wednesday = @wed Where Id = @id", data.GetConnection);
            command.Parameters.Add("@wed", SqlDbType.Int).Value = shiftwed;
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
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
        public bool UppdateShiftColumn4(int id, int shiftthus)
        {
            Database data = new Database();
            SqlCommand command = new SqlCommand("Update Schedule SET thusday = @thus Where Id = @id", data.GetConnection);
            command.Parameters.Add("@thus", SqlDbType.Int).Value = shiftthus;
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
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
        public bool UppdateShiftColumn5(int id, int shiftfri)
        {
            Database data = new Database();
            SqlCommand command = new SqlCommand("Update Schedule SET friday = @fri Where Id = @id", data.GetConnection);
            command.Parameters.Add("@fri", SqlDbType.Int).Value = shiftfri;
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
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
        public bool UppdateShiftColumn6(int id, int shiftsat)
        {
            Database data = new Database();
            SqlCommand command = new SqlCommand("Update Schedule SET satusday = @sat Where Id = @id", data.GetConnection);
            command.Parameters.Add("@sat", SqlDbType.Int).Value = shiftsat;
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
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
        public bool UppdateShiftColumn7(int id, int shiftsun)
        {
            Database data = new Database();
            SqlCommand command = new SqlCommand("Update Schedule SET sunday = @sun Where Id = @id", data.GetConnection);
            command.Parameters.Add("@sun", SqlDbType.Int).Value = shiftsun;
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
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
            //try
            //{
                this.GetShift();
                SqlCommand command = new SqlCommand();
                data.OpenConnection();
                command.Connection = data.GetConnection;
                command.CommandText = "Select id, firstname, lastname, role, monday, tuesday, wednesday, thusday, friday, satusday, sunday from Schedule";
                SqlDataAdapter SDA = new SqlDataAdapter(command);
                SDA.Fill(table);
                return table;
            //}
            //catch
            //{
            //    return table;
            //}
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
