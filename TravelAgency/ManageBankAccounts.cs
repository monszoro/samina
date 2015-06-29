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
    public partial class ManageBankAccounts : Form
    {
        public ManageBankAccounts()
        {
            InitializeComponent();
            loadBankAccounts();
        }

        public void loadBankAccounts()
        {
            dgvBankAccounts.Rows.Clear();
             var query = from bankAccount in TravelAgenceMasterClass.getTravelAgencyContext().BankAccounts
                        select bankAccount;
            foreach (var bAcc in query)
            {
                DataGridViewRow row = new DataGridViewRow();
                DataGridViewTextBoxCell BankName = new DataGridViewTextBoxCell();
                BankName.Value = bAcc.BankName;
                row.Cells.Add(BankName);
                DataGridViewTextBoxCell Anum = new DataGridViewTextBoxCell();
                Anum.Value = bAcc.AccountNumber;
                row.Cells.Add(Anum);
                row.Tag = bAcc;
                dgvBankAccounts.Rows.Add(row);
            }
        }
        private void cmdNew_Click(object sender, EventArgs e)
        {
            NewBankAccount frmNewBankAcc = new NewBankAccount();
            frmNewBankAcc.ShowDialog();
            loadBankAccounts();
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

    //    private void checkBox1_CheckedChanged(object sender, EventArgs e)
    //    {
    //        if (checkBox1.Checked)
    //            dateTimePicker1.Enabled = true;
    //        else
    //            dateTimePicker1.Enabled = false;    
    //    }
    //    public List<Client> ReturnClientSelection()
    //    {
    //        cmdNew.Visible = false;
    //        cmdOk.Visible = true;
    //        colChkBox.Visible = true;
    //        this.ShowDialog();
    //        List<Client> lst = new List<Client>();
    //        foreach (DataGridViewRow row in dgvBankAccounts.Rows)
    //        {
    //            if (row.Cells[0].Value.Equals(true))
    //            {
    //                lst.Add((Client)row.Tag);
    //            }
             
    //         }
    //        return lst;
    //    }

    //    private void cmdOk_Click(object sender, EventArgs e)
    //    {
    //        this.Close();
    //    }

    //    public Client getSelectedClient()
    //    {
    //        return selectedClient;
    //    }
    //
    }
 
}