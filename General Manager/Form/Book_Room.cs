using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
namespace General_Manager.Form
{
    public partial class Book_Room : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        Database db = new Database();
        Room ro = new Room();

        public Book_Room()
        {
            InitializeComponent();
        }

        private void Book_Room_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hotelDataSet.Room' table. You can move, or remove it, as needed.
            RoomTypeLoad();
        }

        public void RoomTypeLoad()
        {
            SqlCommand cmd = new SqlCommand("Select * from RoomType", db.GetConnection);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            roomtype_cb.DataSource = dt;
            roomtype_cb.DisplayMember = "rname";
            roomtype_cb.ValueMember = "rtype";
            cost_tb.Text = dt.Rows[0][3].ToString();
            max_tb.Text = dt.Rows[0][2].ToString();
        }


        bool verify()
        {
            if((name_tb.Text.Trim() == "")
              ||(phone_tb.Text.Trim() == "")
              ||(address_tb.Text.Trim() == "") 
              ||(roomid_tb.Text.Trim() == "")
              ||(roomtype_cb.SelectedValue == null))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void book_btn_Click(object sender, EventArgs e)
        {
            if(verify())
            {
                int rid = Int32.Parse(roomid_tb.Text);
                string cname = name_tb.Text;
                DateTime cbdate = bdate_picker.Value;
                string caddress = address_tb.Text;
                int cphone = Int32.Parse(phone_tb.Text);
                string rtype = roomtype_cb.SelectedValue.ToString();
                DateTime rcheckin = checkin_picker.Value;
                DateTime rcheckout = checkout_picker.Value;
                if(ro.checkRoomID(rid))
                {
                    MessageBox.Show("Room ID already exits", "Book Room", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if(ro.addRoom(rid,cname,cbdate,caddress,cphone,rtype,rcheckin,rcheckout))
                    {
                        MessageBox.Show("Room has been booked successfully", "Book Room", MessageBoxButtons.OK);
                    }
                }
            }
            else
            {
                MessageBox.Show("No blank allowed", "Book Room", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void roomtype_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string type = roomtype_cb.SelectedValue.ToString();
                SqlCommand cmd = new SqlCommand("Select * from RoomType where rtype = '" + type +"'", db.GetConnection);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                cost_tb.Text = dt.Rows[0][3].ToString();
                max_tb.Text = dt.Rows[0][2].ToString();
            }
            catch { }
        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            if (verify())
            {
                int rid = Int32.Parse(roomid_tb.Text);
                string cname = name_tb.Text;
                DateTime cbdate = bdate_picker.Value;
                string caddress = address_tb.Text;
                int cphone = Int32.Parse(phone_tb.Text);
                string rtype = roomtype_cb.SelectedValue.ToString();
                DateTime rcheckin = checkin_picker.Value;
                DateTime rcheckout = checkout_picker.Value;
                    if (ro.updateRoom(rid, cname, cbdate, caddress, cphone, rtype, rcheckin, rcheckout))
                    {
                        MessageBox.Show("Room's information has been updated", "Book Room", MessageBoxButtons.OK);
                    }
            }
            else
            {
                MessageBox.Show("No blank allowed", "Book Room", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
