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
    public partial class NewBankAccount : Form
    {
                private bool FileDialogOpenedFromImage;
                public NewBankAccount()
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
            if (string.IsNullOrEmpty(txtNumber.Text))
            {
                errorProvider1.SetError(txtNumber, "Required Field");
                ExitSave = true;
            }
            else
                errorProvider1.SetError(txtNumber, "");
            if (ExitSave == true)
                    return;

            BankAccount b =new BankAccount();
            b.BankName = txtName.Text;
            b.AccountNumber = txtNumber.Text;
            TravelAgenceMasterClass.TravelAgencyContext.BankAccounts.Add(b);
            TravelAgenceMasterClass.TravelAgencyContext.SaveChanges();
            Close();
        }

       }

}
