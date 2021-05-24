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
using System.Data.Entity;
using DevExpress.XtraEditors;
namespace General_Manager.Form
{
    public partial class Manager : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public Manager()
        {
            InitializeComponent();
        }
        Hotel_Management_Entities db;

        private void ExitProgram() {

        }
        public void Skin()
        {
            //DevExpress.LookAndFeel.DefaultLookAndFeel theme = new DevExpress.LookAndFeel.DefaultLookAndFeel();
            //theme.LookAndFeel.SkinName = "Valentine";
        }


        private void M010103_ItemClick(object sender,DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult delete = MessageBox.Show("Are you sure close program?", "Close Program", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (delete == DialogResult.Yes)
            {
                Application.Exit();
                var changed = db.ChangeTracker.Entries().Where(x => x.State != System.Data.Entity.EntityState.Unchanged).ToList();
                foreach(var obj in changed)
                {
                    switch (obj.State)
                    {
                        case System.Data.Entity.EntityState.Modified:
                            obj.CurrentValues.SetValues(obj.OriginalValues);
                            break;
                        case System.Data.Entity.EntityState.Added:
                            obj.State = System.Data.Entity.EntityState.Detached;
                            break;
                        case System.Data.Entity.EntityState.Deleted:
                            obj.State = System.Data.Entity.EntityState.Unchanged;
                            break;
                    }
                }
                employeeBindingSource.ResetBindings(false);
            }
            else
            {
            }

        }

        private void Manager_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hotel_ManagementDataSet.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.hotel_ManagementDataSet.Employee);
            db = new Hotel_Management_Entities();
            db.Employees.Load();
            employeeBindingSource.DataSource = db.Employees.Local;
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

        private void M010501_ItemClick(object sender, ItemClickEventArgs e)
        {
            employeeBindingSource.AddNew();
        }

        private void M010503_ItemClick(object sender, ItemClickEventArgs e)
        {
            db.SaveChanges();
            XtraMessageBox.Show("You data has been successfully saved", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void M010502_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (XtraMessageBox.Show("Are you sure want to remove this record?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                employeeBindingSource.RemoveCurrent();
        }

        private void PicturePictureEdit_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Select Image(*.jpg;*.png;*.gif)|*.jpg;*.pnq;*.gif";
            if (open.ShowDialog() == DialogResult.OK)
            {
                PicturePictureEdit.Image = Image.FromFile(open.FileName);
            }

        }
    }
}