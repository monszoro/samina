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
using TravelAgency.Util;
using Reporting;
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
          if( cboGeneralLedgerAccount.SelectedIndex>=0)
          {
              int GeneralAccountID=((GeneralLedgerAccount)cboGeneralLedgerAccount.SelectedItem).GeneralLedgerAccountID;
              int SubLedgerAccountID=-1;
              if(cboSubLedgerAccount.SelectedIndex>0)
                  SubLedgerAccountID = ((ComboItem)cboSubLedgerAccount.SelectedItem).Value;

              ReportingForm rf = new ReportingForm();
              rf.ViewLedgerTransactionsreport(GeneralAccountID, SubLedgerAccountID);
            
          }
        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cboGeneralLedgerAccount_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cboGeneralLedgerAccount.SelectedIndex>=0)
            {
                cboSubLedgerAccount.Items.Clear();
                cmdSave.Enabled = true;
                int generalLedgerAccountID = ((GeneralLedgerAccount)cboGeneralLedgerAccount.SelectedItem).GeneralLedgerAccountID;
                var query = from LA in TravelAgenceMasterClass.getTravelAgencyContext().LedgerAccounts
                              where LA.GeneralLedgerAccountID==generalLedgerAccountID 
                             select LA;


                if (query.Count() == 0)
                {
                    cboSubLedgerAccount.Enabled = false;
                    return;
                }

                foreach (var LAccount in query)
                {

                    int AccountID = LAccount.LedgerAccountID;
                    String Name="";

                    if (LAccount.Client != null)                       
                        Name = LAccount.Client.FullName;
                    else if (LAccount.Vendor != null)
                        Name = LAccount.Vendor.Name;
                    else if (LAccount.Cashier != null)
                        Name =LAccount.Cashier.Name;
                    else if (LAccount.BankAccount != null)
                     Name=   LAccount.BankAccount.BankName + " " + LAccount.BankAccount.AccountNumber;
                    else if (LAccount.Expens != null)
                        Name = LAccount.Expens.ExpenseName;

                    cboSubLedgerAccount.Items.Add(new ComboItem(Name, AccountID));
                }


            }

        }
    }
 
}
