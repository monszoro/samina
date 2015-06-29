using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using TravelAgency.Administration;
namespace TravelAgency
{
    public partial class EditCurrency : Form
    {
        private Currency cl;
        private ManageCurrencies frmManageCurrencies;
        public EditCurrency(ManageCurrencies frmManageCurrencies, Currency c)
        {
            InitializeComponent();
            this.cl = c;
            this.frmManageCurrencies = frmManageCurrencies;
            tbxSign.Text = c.Sign;
            txtName.Text = c.Name;

        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            Close();
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

            if (string.IsNullOrEmpty(tbxSign.Text))
            {
                errorProvider1.SetError(tbxSign, "Required Field");
                ExitSave = true;
            }
            else
                errorProvider1.SetError(tbxSign, "");

            if (ExitSave == true)
                return;
            cl = TravelAgenceMasterClass.getTravelAgencyContext().Currencies.Where(c => c.CurrencyID == cl.CurrencyID).SingleOrDefault();
            
            cl.Name = txtName.Text;
            cl.Sign = tbxSign.Text;

            TravelAgenceMasterClass.getTravelAgencyContext().SaveChanges();
            Close();
        }

    }
}
