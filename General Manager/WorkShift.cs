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
        public int[] A = new int[7];
        public int[] B = new int[7];
        public int[] C = new int[7];
        public int Manager { get; set; }
        public int Receptionist { get; set; }
        public int Janitor { get; set; }

        Random random = new Random();
        public int Check { get; set; }
        public int CheckBack { get; set; }
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

            SqlCommand command = new SqlCommand();
            command.Connection = db.GetConnection;
            command.CommandText = "Select Monday, Tuesday, Wednesday Thursday, Friday, Saturday, Sunday from Schedule";
            SqlDataAdapter SDA = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            SDA.Fill(table);
            return table;
        }
        public DataTable ShowId()
        {

            SqlCommand command = new SqlCommand();
            command.Connection = db.GetConnection;
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
    
                SqlCommand command = new SqlCommand(@"Select count(*) from employee where role = 'Manager'", db.GetConnection);
                db.OpenConnection();
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
            Total = Convert.ToInt32(employee.GetNumberJanitor()) + Convert.ToInt32(employee.GetNumberOfManager()) + Convert.ToInt32(employee.GetNumberReceptionist());
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
            Total = Convert.ToInt32(employee.GetNumberJanitor()) + Convert.ToInt32(employee.GetNumberOfManager()) + Convert.ToInt32(employee.GetNumberReceptionist());
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
            Manager = Convert.ToInt32(employee.GetNumberOfManager());
            Receptionist = Convert.ToInt32(employee.GetNumberReceptionist());
            Janitor = Convert.ToInt32(employee.GetNumberJanitor());
            //Monday
            //int[] check = { 1, 3, 4 };
            Check = 0;
            for (int i = 0; i < Total; i++)
            {
                if (arrayRole[i] == "Manager" && Manager > 0)
                {
                    int s1 = random.Next(1, 3);
                    int s2 = random.Next(1, 3);
                    int s3 = random.Next(1, 3);
                    int s4 = random.Next(1, 3);
                    int s5 = random.Next(1, 3);
                    int s6 = random.Next(1, 3);
                    int s7 = random.Next(1, 3);
                    if (Check != 1)
                    {

                        this.UppdateShift(arrayID[i], s1, s2, s3, s4, s5, s6, s7);
                        A[0] = s1; A[1] = s2; A[2] = s3; A[3] = s4; A[4] = s5; A[5] = s6; A[6] = s7;
                        Check = 1;
                    }
                    do
                    {
                        this.UppdateShift(arrayID[i], s1, s2, s3, s4, s5, s6, s7);
                    }
                    while (s1 != A[0] && s2 != A[1] && s3 != A[2] && s4 != A[3] && s5 != A[4]);

                    
                }
                Check = 0;
                if (arrayRole[i] == "Receptionist" && Receptionist > 0)
                {
                    int s1 = random.Next(1, 4);
                    int s2 = random.Next(1, 4);
                    int s3 = random.Next(1, 4);
                    int s4 = random.Next(1, 4);
                    int s5 = random.Next(1, 4);
                    int s6 = random.Next(1, 4);
                    int s7 = random.Next(1, 4);
                    if(Check!= 1)
                    {
                        this.UppdateShift(arrayID[i], s1, s2, s3, s4, s5, s6, s7);
                        B[0] = s1; B[1] = s2; B[2] = s3; B[3] = s4; B[4] = s5; B[5] = s6; B[6] = s7;
                        Check = 1;
                    }
                    else
                    {
                        this.UppdateShift(arrayID[i], B[3], B[5], B[4], B[6], B[2], B[1], B[0]);
                    }

                }
                Check = 0;
                if (arrayRole[i] == "Janitor" && Janitor > 0)
                {
                    int s1 = random.Next(1, 4);
                    int s2 = random.Next(1, 4);
                    int s3 = random.Next(1, 4);
                    int s4 = random.Next(1, 4);
                    int s5 = random.Next(1, 4);
                    int s6 = random.Next(1, 4);
                    int s7 = random.Next(1, 4);
                    if (Check != 1)
                    {
                        this.UppdateShift(arrayID[i], s1, s2, s3, s4, s5, s6, s7);
                        C[0] = s1; C[1] = s2; C[2] = s3; C[3] = s4; C[4] = s5; C[5] = s6; C[6] = s7;
                    }
                    else
                    {
                        this.UppdateShift(arrayID[i], C[3], C[5], C[4], C[6], C[2], C[1], C[0]);
                    }
                }

            }

        }
        public bool UppdateShift(int id, int shiftmon, int shifttu, int shiftwed, int shiftthus, int shiftfri, int shiftsat, int shiftsun)
        {

            SqlCommand command = new SqlCommand("Update Schedule SET Monday = @mon, Tuesday = @tu, Wednesday = @wed, Thursday = @thus, Friday = @fri, Saturday = @sat, Sunday = @sun Where Id = @id", db.GetConnection);
            command.Parameters.Add("@mon", SqlDbType.Int).Value = shiftmon;
            command.Parameters.Add("@tu", SqlDbType.Int).Value = shifttu;
            command.Parameters.Add("@wed", SqlDbType.Int).Value = shiftwed;
            command.Parameters.Add("@thus", SqlDbType.Int).Value = shiftthus;
            command.Parameters.Add("@fri", SqlDbType.Int).Value = shiftfri;
            command.Parameters.Add("@sat", SqlDbType.Int).Value = shiftsat;
            command.Parameters.Add("@sun", SqlDbType.Int).Value = shiftsun;
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            db.OpenConnection();
            if (command.ExecuteNonQuery() > 0)
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
        public bool DeleteData()
        {

            SqlCommand command = new SqlCommand("delete from Schedule", db.GetConnection);
            db.OpenConnection();
            if (command.ExecuteNonQuery() > 0)
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
        public bool InsertShift()
        {

            SqlCommand command = new SqlCommand("insert into Schedule (Id, firstname, lastname, role) select Id, fname, lname, role from Employee", db.GetConnection);
            db.OpenConnection();
            if (command.ExecuteNonQuery() > 0)
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
        public bool UppdateShiftColumn2(int id, int shifttu)
        {

            SqlCommand command = new SqlCommand("Update Schedule SET Tuesday = @tu Where Id = @id", db.GetConnection);
            command.Parameters.Add("@tu", SqlDbType.Int).Value = shifttu;
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            db.OpenConnection();
            if (command.ExecuteNonQuery() > 0)
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
        public bool UppdateShiftColumn1(int id, int shiftmon)
        {

            SqlCommand command = new SqlCommand("Update Schedule SET Monday = @mon Where Id = @id", db.GetConnection);
            command.Parameters.Add("@mon", SqlDbType.Int).Value = shiftmon;
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            db.OpenConnection();
            if (command.ExecuteNonQuery() > 0)
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
        public bool UppdateShiftColumn3(int id, int shiftwed)
        {

            SqlCommand command = new SqlCommand("Update Schedule SET Wednesday = @wed Where Id = @id", db.GetConnection);
            command.Parameters.Add("@wed", SqlDbType.Int).Value = shiftwed;
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            db.OpenConnection();
            if (command.ExecuteNonQuery() > 0)
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
        public bool UppdateShiftColumn4(int id, int shiftthus)
        {

            SqlCommand command = new SqlCommand("Update Schedule SET Thursday = @thus Where Id = @id", db.GetConnection);
            command.Parameters.Add("@thus", SqlDbType.Int).Value = shiftthus;
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            db.OpenConnection();
            if (command.ExecuteNonQuery() > 0)
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
        public bool UppdateShiftColumn5(int id, int shiftfri)
        {

            SqlCommand command = new SqlCommand("Update Schedule SET Friday = @fri Where Id = @id", db.GetConnection);
            command.Parameters.Add("@fri", SqlDbType.Int).Value = shiftfri;
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            db.OpenConnection();
            if (command.ExecuteNonQuery() > 0)
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
        public bool UppdateShiftColumn6(int id, int shiftsat)
        {

            SqlCommand command = new SqlCommand("Update Schedule SET Saturday = @sat Where Id = @id", db.GetConnection);
            command.Parameters.Add("@sat", SqlDbType.Int).Value = shiftsat;
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            db.OpenConnection();
            if (command.ExecuteNonQuery() > 0)
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
        public bool UppdateShiftColumn7(int id, int shiftsun)
        {

            SqlCommand command = new SqlCommand("Update Schedule SET Sunday = @sun Where Id = @id", db.GetConnection);
            command.Parameters.Add("@sun", SqlDbType.Int).Value = shiftsun;
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            db.OpenConnection();
            if (command.ExecuteNonQuery() > 0)
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
        public DataTable ShowShift()
        {
            SqlCommand command = new SqlCommand();
            db.OpenConnection();
            command.Connection = db.GetConnection;
            command.CommandText = "Select id, firstname, lastname, role, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday from Schedule";
            SqlDataAdapter SDA = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            SDA.Fill(table);
            return table;
        }
        public DataTable ShowReloadShift()
        {
            DataTable table = new DataTable();
            //try
            //{
                this.GetShift();
                SqlCommand command = new SqlCommand();
                db.OpenConnection();
                command.Connection = db.GetConnection;
                command.CommandText = "Select id, firstname, lastname, role, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday from Schedule";
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
            string DoW = DateTime.Now.ToString("dddd");
            SqlCommand cmd = new SqlCommand("Select stime, etime from WorkShift W inner join Schedule S on S."+DoW+" = W.Id where S.Id = " + Id, db.GetConnection);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }

        public bool UpdateWorkDuration(int Id, int Mins)
        {
            string DoW = DateTime.Now.ToString("dddd");
            SqlCommand command = new SqlCommand("Update WorkDone set "+DoW+" += @Mins where Id = @Id", db.GetConnection);
            command.Parameters.Add("@Id", SqlDbType.Int).Value = Id;
            command.Parameters.Add("@Mins", SqlDbType.Int).Value = Mins;
            db.OpenConnection();
            if (command.ExecuteNonQuery() > 0)
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

        public bool UpdateWorkShift()
        {
            string CurrentDate = DateTime.Now.ToString("MM/dd/yyyy");
            SqlCommand command = new SqlCommand("update WorkShift SET[stime] = cast('" + CurrentDate + "' as datetime) + cast(cast([stime] as time) as datetime)"
            + ", [etime] = cast('" + CurrentDate + "' as datetime) + cast(cast([etime] as time) as datetime) where Id between 0 and 5", db.GetConnection);
            db.OpenConnection();
            if (command.ExecuteNonQuery() > 0)
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
    }
}
