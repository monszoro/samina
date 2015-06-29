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
    public partial class ManageExpenses : Form
    {
        public ManageExpenses()
        {
            InitializeComponent();
            loadExpenses();
        }

        public void loadExpenses()
        {
            dgvBankAccounts.Rows.Clear();
             var query = from expense in TravelAgenceMasterClass.getTravelAgencyContext().Expenses
                        select expense;
            foreach (var exp in query)
            {
                DataGridViewRow row = new DataGridViewRow();
                DataGridViewTextBoxCell ExpName = new DataGridViewTextBoxCell();
                ExpName.Value = exp.ExpenseName;
                row.Cells.Add(ExpName);
                row.Tag = exp;
                dgvBankAccounts.Rows.Add(row);
            }
        }
        private void cmdNew_Click(object sender, EventArgs e)
        {
            NewExpense frmNewExp = new NewExpense();
            frmNewExp.ShowDialog();
            loadExpenses();
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