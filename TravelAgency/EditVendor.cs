using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
namespace TravelAgency
{
    public partial class EditVendor : Form
    {
        private Vendor ven;
        private bool FileDialogOpenedFromImage;
        public EditVendor(Vendor v)
        {
            InitializeComponent();
            ven = v;
            txtAddress.Text = ven.Address ;
            txtName.Text = ven.Name;
            txtEmail.Text = ven.Email;
            txtPhone.Text = ven.Phone;
            
        }
        private void Tickets_Load(object sender, EventArgs e)
        {

        }
        private void gbFilter_Enter(object sender, EventArgs e)
        {

        }
        private void gbCompany_Enter(object sender, EventArgs e)
        {

        }
        private void cmdSave_Click(object sender, EventArgs e)
        {
            bool ExitSave = false;

            if (string.IsNullOrEmpty(txtName.Text))
            {
                errorProvider1.SetError(txtName, "Required Field");
                ExitSave = true;
            }
            else
                errorProvider1.SetError(txtName, "");

            
            if (ExitSave == true)
                return;
            ven = TravelAgenceMasterClass.getTravelAgencyContext().Vendors.Where(v => v.VendorID == ven.VendorID).SingleOrDefault();

            ven.Address = txtAddress.Text;
            ven.Phone=txtPhone.Text;
            ven.Email = txtEmail.Text;
            ven.Name = txtName.Text;
            TravelAgenceMasterClass.getTravelAgencyContext().SaveChanges();    
            Close();
        }



        private void cmdEdit_Click(object sender, EventArgs e)
        {
            foreach (Control c in this.Controls)
            {
                foreach (Control c1 in c.Controls)
                {
                    if (c1 is TextBox)
                        ((TextBox)c1).ReadOnly = false;
                    else if (c1 is DateTimePicker)
                        ((DateTimePicker)c1).Enabled = true;
                }
            }
            cmdEdit.SendToBack();}
           }

}
