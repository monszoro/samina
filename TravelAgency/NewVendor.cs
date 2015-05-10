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
    public partial class NewVendor : Form
    {
                private bool FileDialogOpenedFromImage;
          public NewVendor()
        {
            InitializeComponent();
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

            TravelAgencyEntities t = new TravelAgencyEntities();
            //Client c = new Client();

            //  t.AddToClients(Client.CreateClient(1, "sami", "a@a.com", "Sami", "Ahmed"));
            //t.SaveChanges();


        }

       

        private void cmdSave_Click_1(object sender, EventArgs e)
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

            Vendor v =new  Vendor();
            v.Name= txtName.Text;
            v.DateCreated=DateTime.Now;
            v.CreationUserID = TravelAgenceMasterClass.CurrentUser.UserID;
            v.Address = txtAddress.Text;
            v.Email = txtEmail.Text;
            v.Phone = txtPhone.Text;
            TravelAgenceMasterClass.TravelAgencyContext.Vendors.Add (v);
            TravelAgenceMasterClass.TravelAgencyContext.SaveChanges();
            Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

      
        private void cmdCancel_Click(object sender, EventArgs e)
        {

        }
    }

}
