using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace General_Manager.Form
{
    public partial class Display_User : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public Display_User()
        {
            InitializeComponent();
        }
        Hotel_ManagementEntities3 db;
        private void Watch_Load(object sender, EventArgs e)
        {

        }

        private void customerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.customerBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.hotel_ManagementDataSet1);

        }

        private void Display_User_Load(object sender, EventArgs e)
        {
            db = new Hotel_ManagementEntities3();
            // TODO: This line of code loads data into the 'hotel_ManagementDataSet1.Customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.hotel_ManagementDataSet1.Customer);
            db.Customers.Load();
            customerBindingSource.DataSource = db.Customers.Local;
            
        }

        private void Addnew_btn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            customerBindingSource.AddNew();
        }

        private void Save_btn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(IdTextEdit.Text);
                db.SaveChanges();
                XtraMessageBox.Show("You data has been successfully saved", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                XtraMessageBox.Show("ID already exist in list! Please change another ID", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Delete_btn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (XtraMessageBox.Show("Are you sure want to remove this record?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                customerBindingSource.RemoveCurrent();
        }

        private void Close_btn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult delete = XtraMessageBox.Show("Are you sure close program?", "Close Program", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (delete == DialogResult.Yes)
            {
                Application.Exit();
                var changed = db.ChangeTracker.Entries().Where(x => x.State != System.Data.Entity.EntityState.Unchanged).ToList();
                foreach (var obj in changed)
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
                customerBindingSource.ResetBindings(false);

            }
            else
            {
            }
        }
    }
}