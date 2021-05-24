using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using General_Manager.Form;

namespace General_Manager.Form
{
    public partial class Menu : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public Menu()
        {
            InitializeComponent();
        }
        private void ExitProgram() {
            DialogResult delete = MessageBox.Show("Are you sure close program?", "Close Program", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (delete == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
                {
                }
        }
        public void Skin()
        {
            DevExpress.LookAndFeel.DefaultLookAndFeel theme = new DevExpress.LookAndFeel.DefaultLookAndFeel();
            theme.LookAndFeel.SkinName = "DevExpress Style";
        }

        private void M010103_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.ExitProgram();

        }

        private void Manager_Load(object sender, EventArgs e)
        {
            this.Skin();
        }

        private void M010201_ItemClick(object sender, ItemClickEventArgs e)
        {
            Display_User display = new Display_User();
            display.Show();
        }

        private void M010202_ItemClick(object sender, ItemClickEventArgs e)
        {

        }
        private void M010101_ItemClick(object sender, ItemClickEventArgs e)
        {          
            Login login = new Login();
            this.Hide();
            login.Show();
        }

        private void bookroom_item_ItemClick(object sender, ItemClickEventArgs e)
        {
            Book_Room ro = new Book_Room();
            ro.Show();
        }
    }
}