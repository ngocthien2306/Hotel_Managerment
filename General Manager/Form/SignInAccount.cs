using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace General_Manager.Form
{
    public partial class SignInAccount : DevExpress.XtraEditors.XtraForm
    {
        public SignInAccount()
        {
            InitializeComponent();
        }

        private void SignIn_btn_Click(object sender, EventArgs e)
        {
            try
            {
                Random ran = new Random();
                User customer = new User();
                int id = ran.Next(1, 2000000);
                string full = Fullname_Textbox.Text;
                int cmnd = Convert.ToInt32(Cmnd_Textbox.Text);
                string username = Username_Textbox.Text;
                string pass = Password_Textbox.Text;
                DateTime birthday = Birthday_edit.DateTime;
                MemoryStream pic = new MemoryStream();
                PictureUser.Image.Save(pic, PictureUser.Image.RawFormat);
                User user = new User();
                if (user.Insert_User(id, full, pic, birthday, pass, username, cmnd))
                {
                    XtraMessageBox.Show("Sign in account succussful!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    XtraMessageBox.Show("Sign in account failed!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch
            {
                XtraMessageBox.Show("Sign in account failed!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void PictureUser_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Select Image(*.jpg;*.png;*.gif)|*.jpg;*.pnq;*.gif";
            if (open.ShowDialog() == DialogResult.OK)
            {
                PictureUser.Image = Image.FromFile(open.FileName);
            }
        }

        private void HyperlinkLabelControl_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }
    }
}