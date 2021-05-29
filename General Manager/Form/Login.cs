using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using General_Manager.Form;
namespace General_Manager.Form
{
    public partial class Login : DevExpress.XtraEditors.XtraForm
    {

        static public int CurrentID { get; set; }
        static public void GetID(int UserID)
        {
            CurrentID = UserID;
        }

        Database db = new Database();
        public Login()
        {
            InitializeComponent();
        }
        public void RoleLogin()
        {
            try
            {
                string role = "";
                EmployeeHotel user = new EmployeeHotel();
                User customer = new User();
                user.ID = Convert.ToInt32(Username_tb.Text);
                user.Password = Password_tb.Text;
                string username = Username_tb.Text;
                string password = Password_tb.Text;
                Database data = new Database();
                SqlCommand command = new SqlCommand("SELECT Id, password, fname, lname, CMND, bdate, address, phone, email, " +
                    "salary, role, daywork, work, picture, gender, shift FROM Employee WHERE Id = @id AND password = @pass", data.GetConnection);
                command.Parameters.Add("@id", SqlDbType.Int).Value = Username_tb.Text;
                command.Parameters.Add("@pass", SqlDbType.NVarChar).Value = Password_tb.Text;
                data.OpenConnection();
                DataTable table = user.GetUsers(command);
                if (table.Rows.Count > 0)
                {
                    SqlDataAdapter SDA = new SqlDataAdapter();
                    SDA.SelectCommand = command;
                    DataSet set = new DataSet();
                    SDA.Fill(set, "Employee");
                    data.CloseConnection();
                    role = table.Rows[0]["role"].ToString().Trim();
                    int UserId = Convert.ToInt32(table.Rows[0]["id"].ToString());
                    byte[] pic = (byte[])table.Rows[0]["picture"];
                    MemoryStream picture = new MemoryStream(pic);
                    GetID(UserId);
                    WorkShift w = new WorkShift();
                    if (user.GetLogin() && role == "Manager" && Manager_rbt.Checked == true)
                    {
                        Menu manager = new Menu();
                        manager.Label_ShowId.Text = UserId.ToString();
                        manager.Label_wcome.Text = "Wellcome back " + table.Rows[0]["fname"].ToString().Trim();
                        manager.PictureUser.Image = Image.FromStream(picture);
                        //w.InsertId(Convert.ToInt32(UserId));
                        manager.ShowDialog();
                    }
                    else if (user.GetLogin() && role == "Receptionist" && Receptionist_rbt.Checked == true)
                    {

                    }
                    else if (user.GetLogin() && role == "Janior" && Janitor_rbt.Checked == true)
                    {

                    }
                    else if (Radio_Customer.Checked == true && customer.Login(username, password) )
                    {
                        Book_Room book = new Book_Room();
                        book.ShowDialog();
                    }
                    else
                    {
                        XtraMessageBox.Show("Invalid Username of wrong Password, Try again or Create new account", "Login", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    XtraMessageBox.Show("Invalid Username of wrong Password, Try again or Create new account", "Login", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
        }
        catch
            {
                XtraMessageBox.Show("Invalid Username of wrong Password, Try again or Create new account", "Login", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
  
        
        private void Login_bt_Click(object sender, EventArgs e)
        {
            this.RoleLogin();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void Exit_bt_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Radio_Customer_CheckedChanged(object sender, EventArgs e)
        {
            HyperlinkLabelControl_create.Visible = true;
            Receptionist_rbt.Checked = false;
            Janitor_rbt.Checked = false;
            Manager_rbt.Checked = false;
        }

        private void Manager_rbt_CheckedChanged(object sender, EventArgs e)
        {
            Receptionist_rbt.Checked = false;
            Janitor_rbt.Checked = false;
            HyperlinkLabelControl_create.Visible = false;
            Radio_Customer.Checked = false;
        }

        private void Receptionist_rbt_CheckedChanged(object sender, EventArgs e)
        {
            Manager_rbt.Checked = false;
            Janitor_rbt.Checked = false;
            HyperlinkLabelControl_create.Visible = false;
            Radio_Customer.Checked = false;
        }

        private void Janitor_rbt_CheckedChanged(object sender, EventArgs e)
        {
            Manager_rbt.Checked = false;
            Receptionist_rbt.Checked = false;
            HyperlinkLabelControl_create.Visible = false;
            Radio_Customer.Checked = false;
        }

        private void HyperlinkLabelControl_create_Click(object sender, EventArgs e)
        {
            SignInAccount sign = new SignInAccount();
            this.Hide();
            sign.ShowDialog();
        }
    }
}