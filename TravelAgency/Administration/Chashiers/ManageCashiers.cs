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
    public partial class ManageCashiers : Form
    {
        public ManageCashiers()
        {
            InitializeComponent();
            loadcashiers();
        }

        public void loadcashiers()
        {
            dgvBankAccounts.Rows.Clear();
             var query = from cash in TravelAgenceMasterClass.getTravelAgencyContext().Cashiers
                         select cash;
            foreach (var cashier in query)
            {
                DataGridViewRow row = new DataGridViewRow();
                DataGridViewTextBoxCell CashExp = new DataGridViewTextBoxCell();
                CashExp.Value = cashier.Name;
                row.Cells.Add(CashExp);
                row.Tag = cashier;
                dgvBankAccounts.Rows.Add(row);
            }
        }
        private void cmdNew_Click(object sender, EventArgs e)
        {
            NewCashier  frmnewCash = new NewCashier();
            frmnewCash.ShowDialog();
            loadcashiers();
       }

      private void dgvExpense_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
    //      if (dgvBankAccounts.SelectedRows.Count > 0)
    //        {
    //            selectedClient = (Client)dgvBankAccounts.SelectedRows[0].Tag;
    //            if (allowDetails)
    //            {
    //                EditClient frmEdit = new EditClient(this, selectedClient);
    //                frmEdit.ShowDialog();
    //            }
    //            else
    //            {
    //                Close();
    //            }
    //        }
        }

   
    }
 
}