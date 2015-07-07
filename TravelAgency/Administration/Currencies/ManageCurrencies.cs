using Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TravelAgency.Administration
{
    public partial class ManageCurrencies : Form
    {
        public ManageCurrencies()
        {
            InitializeComponent();
            loadCurrencies();
        }

        public void loadCurrencies()
        {
            
            dgvCurrencies.Rows.Clear();
            var query = from cash in TravelAgenceMasterClass.getTravelAgencyContext().Currencies
                        select cash;
            foreach (var currency in query)
            {
                DataGridViewRow row = new DataGridViewRow();
                DataGridViewTextBoxCell CashExp = new DataGridViewTextBoxCell();
                CashExp.Value = currency.Name;
                row.Cells.Add(CashExp);

                DataGridViewTextBoxCell CashSign = new DataGridViewTextBoxCell();
                CashSign.Value = currency.Sign;
                row.Cells.Add(CashSign);
                row.Tag = currency;
                dgvCurrencies.Rows.Add(row);
            }
        }
        private void cmdNew_Click_1(object sender, EventArgs e)
        {

            NewCurrency frmnewCash = new NewCurrency();
            frmnewCash.ShowDialog();
            loadCurrencies();
        }

        private void dgvCurrency_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCurrencies.SelectedRows.Count > 0)
            {
                Currency selectedClient = (Currency)dgvCurrencies.SelectedRows[0].Tag;
                EditCurrency frmEdit = new EditCurrency(this, selectedClient);
                frmEdit.ShowDialog();
                    loadCurrencies();
            }
        }
    }
}
