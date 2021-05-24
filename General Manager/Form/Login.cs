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
            User user = new User();
            user.ID = Convert.ToInt32(Username_tb.Text);
            user.Password = Password_tb.Text;
            Database data = new Database();
            SqlCommand command = new SqlCommand("SELECT Id, password, fname, lname, CMND, bdate, address, phone, email, " +
                "salary, role, daywork, work, picture, gender FROM Employee WHERE Id = @id AND password = @pass", data.GetConnection);
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

                if (user.GetLogin() && role == "Manager" && Manager_rbt.Checked == true)
                {
                    Manager manager = new Manager();
                    manager.ShowDialog();
                }
                else if (user.GetLogin() && role == "" && Receptionist_rbt.Checked == true)
                {

                }
                else if (user.GetLogin() && role == "" && Janitor_rbt.Checked == true)
                {

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
        

        //public string GetID()
        //{

        //    string id = "";
        //    try
        //    {
        //        data.OpenConnection();
        //        SqlCommand command = new SqlCommand("SELECT * FROM Account Where username = @user AND password = @pass", data.GetConnection);
        //        command.Parameters.Add("@user", SqlDbType.NVarChar).Value = Username_tb.Text;
        //        command.Parameters.Add("@pass", SqlDbType.NVarChar).Value = Password_tb.Text;
        //        SqlDataAdapter SDA = new SqlDataAdapter(command);
        //        DataTable table = new DataTable();
        //        SDA.Fill(table);
        //        if(table!= null)
        //        {
        //            foreach(DataRow datarow in table.Rows)
        //            {
        //                id = datarow["userID"].ToString();
        //            }
        //        }
        //    }
        //    catch (Exception a)
        //    {
        //        MessageBox.Show(a.Message);
        //    }
        //    finally
        //    {
        //        data.CloseConnection();
        //    }
        //    return id;
        //}
        //public static string ID_User = "";
        // --------
        //private void LoginLoad()
        //{
        //    try
        //    {
        //        //    ID_User = this.GetID();
        //        if (Username_tb.Text != "" || Password_tb.Text != "")
        //            {
        //                if(manager_rbt.Checked == true)
        //            {
        //                Role = "Manager";
        //            }
        //                else if (receptionist_rbt.Checked == true)
        //            {
        //                Role = "Receptionist";
        //            }
        //                else
        //            {
        //                Role = "Janitor";
        //            }
        //            SqlDataAdapter SDA = new SqlDataAdapter();
        //            SqlCommand command = new SqlCommand("SELECT * FROM "+ Role +" WHERE ID = @User AND Password = @Pass", db.GetConnection);
        //            command.Parameters.Add("@User", SqlDbType.NVarChar).Value = Username_tb.Text;
        //            command.Parameters.Add("@Pass", SqlDbType.NVarChar).Value = Password_tb.Text;
        //            SDA.SelectCommand = command;
        //            DataTable table = new DataTable();
        //            SDA.Fill(table);
        //            if (table.Rows.Count > 0)
        //            {
        //            Menu ma = new Menu();
        //            MessageBox.Show("Login Successful", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //                switch(Role)
        //                {
        //                case "Manager":
        //                    this.Hide();
        //                    ma.Show();
        //                    break;
        //                case "Receptionist":
        //                    this.Hide();
        //                    ma.Show();
        //                    break;
        //                case "Janitor":
        //                    this.Hide();
        //                    ma.Show();
        //                    break;
        //                }
        //            }
        //            else
        //            {
        //                MessageBox.Show("Invalid Username of wrong Password, Try again or Create new account", "Login", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //            }
        //        }
        //        else
        //        {
        //            MessageBox.Show("Invalid Username of wrong Password, Try again or Create new account", "Login", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //        }

        //    }
        //    catch (Exception a)
        //    {
        //        MessageBox.Show(a.Message);
        //    }

        //}
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
    }
}