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
        public void LoginWithCustomer()
        {
            try
            {
                string username = Username_tb.Text;
                string password = Password_tb.Text;
                User customer = new User();
                Database data = new Database();
                Book_Room book = new Book_Room();
                SqlCommand command = new SqlCommand("select Id, fullname, picture, birthday, password, username, CMND FROM Customer WHERE username = @user AND password = @pass", data.GetConnection);
                command.Parameters.Add("@user", SqlDbType.NVarChar).Value = username;
                command.Parameters.Add("@pass", SqlDbType.NVarChar).Value = password;
                DataTable table1 = customer.GetUser(command);
                data.OpenConnection();
                if (table1.Rows.Count > 0)
                {
                    SqlDataAdapter SDA = new SqlDataAdapter();
                    SDA.SelectCommand = command;
                    DataSet set = new DataSet();
                    SDA.Fill(set, "Customer");
                    data.CloseConnection();
                    if(customer.Login(username, password))
                    {
                        string fullname = table1.Rows[0]["fullname"].ToString().Trim();
                        book.Label_DisName.Text = fullname;
                        book.Label_displayID.Text = table1.Rows[0]["Id"].ToString().Trim();
                        byte[] pic = (byte[])table1.Rows[0]["picture"];
                        MemoryStream picture = new MemoryStream(pic);
                        book.PictureUser.Image = Image.FromStream(picture);
                        customer.Fullname = fullname;
                        customer.Username = username;
                        customer.Description = "Login account";
                        customer.DayLog = DateTimeOffset.Now;
                        customer.SaveHistoryLogin();
                        customer.Description += customer.Description;
                        book.ShowDialog();
                    }
                }
                else
                {
                    XtraMessageBox.Show("Invalid Username of wrong Password, Try again or Create new account", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch
            {
                XtraMessageBox.Show("Invalid Username of wrong Password, Try again or Create new account", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void RoleLogin()
        {
            try
            {
                if (Radio_Customer.Checked == true)
                {
                    this.LoginWithCustomer();
                }
                else {
                    string role = "";
                    EmployeeHotel user = new EmployeeHotel();
                    user.ID = Convert.ToInt32(Username_tb.Text);
                    user.Password = Password_tb.Text;

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
                        string fname = table.Rows[0]["fname"].ToString().Trim();
                        string lname = table.Rows[0]["lname"].ToString().Trim();
                        GetID(UserId);
                        WorkShift w = new WorkShift();
                        if (user.GetLogin() && role == "Manager" && Manager_rbt.Checked == true)
                        {
                            Menu manager = new Menu();
                            manager.Label_ShowId.Text = UserId.ToString();
                            manager.Label_wcome.Text = "Wellcome back " + table.Rows[0]["fname"].ToString().Trim();
                            manager.PictureUser.Image = Image.FromStream(picture);
                            //w.InsertId(Convert.ToInt32(UserId));
                            user.Daylog = DateTime.Now;
                            user.Fullname = fname + " " + lname;
                            user.Description = "Login account";
                            user.Role = role;
                            user.SaveHistoryLogin();
                            manager.dataLayoutControl1.Visible = false;
                            manager.GridControl.Visible = false;
                            manager.ShowDialog();
                        }
                        else if (user.GetLogin() && role == "Receptionist" && Receptionist_rbt.Checked == true)
                        {

                        }
                        else if (user.GetLogin() && role == "Janitor" && Janitor_rbt.Checked == true)
                        {

                        }
                        else
                        {
                            XtraMessageBox.Show("Invalid Username of wrong Password, Try again or Create new account", "Login", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
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