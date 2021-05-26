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
        public void GetShift()
        {
            EmployeeHotel employee = new EmployeeHotel();
            int manager = Convert.ToInt32(employee.GetNumberOfManager());
            int receptionist = Convert.ToInt32(employee.GetNumberReceptionist());
            int janior = Convert.ToInt32(employee.GetNumberJanior());
            int a = 21010000;
            for (int i = 0; i < manager; i++)
            {
                this.UppdateShift("","Oke",a);
                a += 1;
            }
        }
        public bool InsertShift(string shift)
        {
            Database data = new Database();
            SqlCommand command = new SqlCommand("INSERT INTO Schedule (monday) VALUES (@s)", data.GetConnection);
            command.Parameters.Add("@s", SqlDbType.NVarChar).Value = shift;
            data.OpenConnection();
            if (command.ExecuteNonQuery() > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool UppdateShift(string shiftmon, string shifttu, int id)
        {
            Database data = new Database();
            SqlCommand command = new SqlCommand("Update Schedule SET monday = @mon, tuesday = @tu Where Id = @id", data.GetConnection);
            command.Parameters.Add("@mon", SqlDbType.NVarChar).Value = shiftmon;
            command.Parameters.Add("@tu", SqlDbType.NVarChar).Value = shifttu;
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            data.OpenConnection();
            if(command.ExecuteNonQuery() > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public DataTable ShowShift()
        {
            this.GetShift();
            Database data = new Database();
            SqlCommand command = new SqlCommand();
            command.Connection = data.GetConnection;
            command.CommandText = "Select id, firstname, lastname, monday, tuesday from Schedule";
            SqlDataAdapter SDA = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            SDA.Fill(table);
            return table;
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
