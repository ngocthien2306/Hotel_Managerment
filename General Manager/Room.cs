using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace General_Manager.Form
{
    class Room
    {
        Database db = new Database();

        public bool checkRoomID(int rid)
        {
            SqlCommand command = new SqlCommand("select * from ROOM where rid = @rid", db.GetConnection);
            command.Parameters.Add("@rid", SqlDbType.Int).Value = rid;
            SqlDataAdapter sda = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            db.OpenConnection();

            if ((dt.Rows.Count > 0))
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

        public bool addRoom(int rid, string cname, DateTime cbdate, string caddress, int cphone,string rtype, DateTime rcheckin, DateTime rcheckout)
        {
            SqlCommand command = new SqlCommand("INSERT INTO ROOM (rid, cname,cbdate,caddress,cphone,rtype,rcheckin,rcheckout)" +
                "VALUES (@rid,@cname,@cbdate,@caddress,@cphone,@rtype,@rcheckin,@rcheckout)", db.GetConnection);
            command.Parameters.Add("@rid", SqlDbType.Int).Value = rid;
            command.Parameters.Add("@cname", SqlDbType.NVarChar).Value = cname;
            command.Parameters.Add("@cbdate", SqlDbType.Date).Value = cbdate;
            command.Parameters.Add("@caddress", SqlDbType.NVarChar).Value = caddress;
            command.Parameters.Add("@cphone", SqlDbType.Int).Value = cphone;
            command.Parameters.Add("@rtype", SqlDbType.NVarChar).Value = rtype;
            command.Parameters.Add("@rcheckin", SqlDbType.Date).Value = rcheckin;
            command.Parameters.Add("@rcheckout", SqlDbType.Date).Value = rcheckout;

            db.OpenConnection();

            if ((command.ExecuteNonQuery() == 1))
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
        public bool deleteRoom(int rid)
        {
            SqlCommand command = new SqlCommand("DELETE FROM ROOM WHERE rid = @rid", db.GetConnection);
            command.Parameters.Add("@rid", SqlDbType.Int).Value = rid;
            db.OpenConnection();
            if ((command.ExecuteNonQuery() == 1))
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

        public bool updateRoom(int rid, string cname, DateTime cbdate, string caddress, int cphone,string rtype, DateTime rcheckin, DateTime rcheckout)
        {
            SqlCommand command = new SqlCommand("UPDATE ROOM SET cname = @cname, cbdate = @cbdate, caddress = @caddress, cphone = @cphone,rtype = @rtype, rcheckin = @rcheckin, rcheckout = @rcheckout " +
                "where rid = @rid", db.GetConnection);
            command.Parameters.Add("@rid", SqlDbType.Int).Value = rid;
            command.Parameters.Add("@cname", SqlDbType.NVarChar).Value = cname;
            command.Parameters.Add("@cbdate", SqlDbType.Date).Value = cbdate;
            command.Parameters.Add("@caddress", SqlDbType.NVarChar).Value = caddress;
            command.Parameters.Add("@cphone", SqlDbType.Int).Value = cphone;
            command.Parameters.Add("@rtype", SqlDbType.NVarChar).Value = rtype;
            command.Parameters.Add("@rcheckin", SqlDbType.Date).Value = rcheckin;
            command.Parameters.Add("@rcheckout", SqlDbType.Date).Value = rcheckout;

            db.OpenConnection();

            if ((command.ExecuteNonQuery() == 1))
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

        public DataTable getRoomID(int rid)
        {
            SqlCommand cmd = new SqlCommand("Select * from RoomType where rid = @rid", db.GetConnection);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }
    }
}
