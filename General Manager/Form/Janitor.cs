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
    public partial class Janitor : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public Janitor()
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
            theme.LookAndFeel.SkinName = "Valentine";
        }
        private void ribbon_Click(object sender, EventArgs e)
        {
            
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
            Login lo = new Login();
            this.Hide();
            lo.Show();
        }
    }
}