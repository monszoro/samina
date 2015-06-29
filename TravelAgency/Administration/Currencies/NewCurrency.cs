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
    public partial class NewCurrency : Form
    {
        public NewCurrency()
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
            {
                errorProvider1.SetError(txtName, "");
            }

            if (string.IsNullOrEmpty(tbxSign.Text))
            {
                errorProvider1.SetError(tbxSign, "Required Field");
                ExitSave = true;
            }
            else
            {
                errorProvider1.SetError(tbxSign, "");
            }
            if (ExitSave == true)
                return;
            Currency c = new Currency();
            c.Name = txtName.Text;
            c.Sign = tbxSign.Text;
            TravelAgenceMasterClass.getTravelAgencyContext().Currencies.Add(c);
            TravelAgenceMasterClass.getTravelAgencyContext().SaveChanges();
            Close();
        }

       }

}
