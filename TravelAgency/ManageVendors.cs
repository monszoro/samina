using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
namespace TravelAgency
{
    public partial class ManageVendors : Form
    {
        public ManageVendors()
        {
            InitializeComponent();
        }

       
        private void cmdClear_Click(object sender, EventArgs e)
        {
            foreach (Control c in gbClients.Controls)
            {
                if (c is TextBox)
                    c.Text = "";
            }
            dgvExpense.Rows.Clear();
        }

        private void cmdSearch_Click(object sender, EventArgs e)
        {
            dgvExpense.Rows.Clear();
            TravelAgencyEntities t = new TravelAgencyEntities();
            var query = from V in t.Vendors 
                        where V.Name.Contains(txtName.Text) 
                        && ( V.Phone==null || V.Phone.Contains(txtPhone.Text))
                        && (V.Email==null||V.Email.Contains(txtEmail.Text))
                        select V;
            foreach (var vendor in query)
            {

                DataGridViewRow row = new DataGridViewRow();
                DataGridViewTextBoxCell ID = new DataGridViewTextBoxCell();
                ID.Value = vendor.VendorID.ToString ();
                row.Cells.Add(ID);
                DataGridViewTextBoxCell Name = new DataGridViewTextBoxCell();
                Name.Value = vendor.Name;
                row.Cells.Add(Name);
                DataGridViewTextBoxCell CellPhone = new DataGridViewTextBoxCell();
                CellPhone.Value = vendor.Phone;
                row.Cells.Add(CellPhone);
                DataGridViewTextBoxCell Email = new DataGridViewTextBoxCell();
                Email.Value = vendor.Email;
                row.Cells.Add(Email);
                row.Tag = vendor;
                dgvExpense.Rows.Add(row);
            }
        }

        private void cmdNew_Click(object sender, EventArgs e)
        {
            NewVendor  frmNewVendor= new NewVendor ();
            frmNewVendor.ShowDialog();
        }

        private void dgvExpense_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvExpense.SelectedRows.Count > 0)
            {
                Vendor v = (Vendor)dgvExpense.SelectedRows[0].Tag;
                EditVendor frmEdit = new EditVendor(v);
                frmEdit.ShowDialog();
            }


        }

         }
 
}
