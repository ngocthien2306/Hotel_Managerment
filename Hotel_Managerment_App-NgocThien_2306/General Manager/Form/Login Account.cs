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

namespace General_Manager.Form
{
    public partial class Login_Account : DevExpress.XtraEditors.XtraForm
    {
        My_Database data = new My_Database();
        public Login_Account()
        {
            InitializeComponent();
        }
        public string GetID()
        {
            
            string id = "";
            try
            {
                data.OpenConnection();
                SqlCommand command = new SqlCommand("SELECT * FROM Account Where username = @user AND password = @pass", data.GetConnection);
                command.Parameters.Add("@user", SqlDbType.NVarChar).Value = Username_tb.Text;
                command.Parameters.Add("@pass", SqlDbType.NVarChar).Value = Password_tb.Text;
                SqlDataAdapter SDA = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                SDA.Fill(table);
                if(table!= null)
                {
                    foreach(DataRow datarow in table.Rows)
                    {
                        id = datarow["userID"].ToString();
                    }
                }
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
            }
            finally
            {
                data.CloseConnection();
            }
            return id;
        }
        public static string ID_User = "";
        private void Login()
        {
            try
            {
                ID_User = this.GetID();
                if(ID_User != "")
                {
                    
                    SqlDataAdapter SDA = new SqlDataAdapter();
                    SqlCommand command = new SqlCommand("SELECT * FROM Account WHERE Username = @User AND Password = @Pass", data.GetConnection);
                    command.Parameters.Add("@User", SqlDbType.NVarChar).Value = Username_tb.Text;
                    command.Parameters.Add("@Pass", SqlDbType.NVarChar).Value = Password_tb.Text;
                    SDA.SelectCommand = command;
                    DataTable table = new DataTable();
                    SDA.Fill(table);
                    if (table.Rows.Count > 0)
                    {
                        MessageBox.Show("Login Successful", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Manager manager = new Manager();                       
                        manager.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Invalid Username of wrong Password, Try again or Create new account", "Login", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Username of wrong Password, Try again or Create new account", "Login", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            catch(Exception a)
            {
                MessageBox.Show(a.Message);
            }
            
        }
        private void Login_bt_Click(object sender, EventArgs e)
        {
            this.Login();
            this.Hide();
        }

        private void SignIn_bt_Click(object sender, EventArgs e)
        {
            Signin_Account sign = new Signin_Account();
            sign.Show();
        }
    }
}