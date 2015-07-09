using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Database;
using System.Data.Entity.Core.Objects;
namespace TravelAgency
{
    public partial class LedgerTransactionsReport : Form
    {

        
        public LedgerTransactionsReport()
        {
            InitializeComponent();
        
                      var query = from g in TravelAgenceMasterClass.getTravelAgencyContext().GeneralLedgerAccounts
                        select g;
            cboGeneralLedgerAccount.ValueMember = "Name";
            foreach (var gLedger in query)
            {
                cboGeneralLedgerAccount.Items.Add(gLedger);
            }
        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            //if (String.IsNullOrEmpty(txtUserName.Text))
            //{
            //    errorProvider1.SetError(txtUserName, "Required Field");
            //    return;
            //}
            //else
            //{
            //    errorProvider1.SetError(txtUserName, "");
            //}
            //User u = new User();
            //u.UserName =txtUserName.Text;
            //u.Login= txtLogin.Text;
            //u.Password=txtPassword.Text;
            //u.UserGroup = ((UserGroup)cboUserGroups.SelectedItem);
            //u.isActive = true;
            //TravelAgenceMasterClass.getTravelAgencyContext().Users.Add(u);
            //TravelAgenceMasterClass.getTravelAgencyContext().SaveChanges();
            //NewUserAdded = true;
            //this.Close();
        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cboGeneralLedgerAccount_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cboGeneralLedgerAccount.SelectedIndex>=0)
            {
                cboSubLedgerAccoutn.Items.Clear();
                cmdSave.Enabled = true;
                int generalLedgerAccountID = ((GeneralLedgerAccount)cboGeneralLedgerAccount.SelectedItem).GeneralLedgerAccountID;
                var query = from LA in TravelAgenceMasterClass.getTravelAgencyContext().LedgerAccounts
                              where LA.GeneralLedgerAccountID==generalLedgerAccountID 
                             select LA;


                if (query.Count() == 0)
                {
                    cboSubLedgerAccoutn.Enabled = false;
                    return;
                }

                foreach (var LAccount in query)
                {

                    if (LAccount.Client != null)
                        cboSubLedgerAccoutn.Items.Add(LAccount.Client.FullName);
                    else if (LAccount.Vendor != null)
                        cboSubLedgerAccoutn.Items.Add(LAccount.Vendor.Name);
                    else if (LAccount.Cashier != null)
                        cboSubLedgerAccoutn.Items.Add(LAccount.Cashier.Name);
                    else if (LAccount.BankAccount!=null)
                        cboSubLedgerAccoutn.Items.Add(LAccount.BankAccount.BankName + " " + LAccount.BankAccount.AccountNumber );
                    else if (LAccount.Expens!=null)
                        cboSubLedgerAccoutn.Items.Add(LAccount.Expens.ExpenseName);
                }


            }

        }
    }
 
}
