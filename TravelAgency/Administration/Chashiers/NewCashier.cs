using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Database;
namespace TravelAgency
{
    public partial class NewCashier : Form
    {
       public NewCashier()
        {
            InitializeComponent();
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
                      Cashier c = new Cashier();
            c.Name = txtName.Text;
            TravelAgenceMasterClass.getTravelAgencyContext().Cashiers.Add(c);
            TravelAgenceMasterClass.getTravelAgencyContext().SaveChanges();
            Close();
        }

       }

}
