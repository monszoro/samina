using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Database;
using TravelAgency.Util;

namespace TravelAgency.UserControls
{
    public partial class AccountCurrenciesAmount : UserControl
    {
        static int LE = 1;

        private bool checkAvailblity;
        public AccountCurrenciesAmount()
        {
            InitializeComponent();
            //

        }
        public void loadControl(bool checkAvailblity)
        {
            LoadComboBoxes();
            cboPaymentTypes.SelectedIndex = 0;
            cboCurrencies.SelectedIndex = 0;
            this.checkAvailblity = checkAvailblity;
        }

        private void LoadComboBoxes()
        {

            var query = from c in TravelAgenceMasterClass.getTravelAgencyContext().Cashiers
                        select c;
            cboCashiers.ValueMember = "Name";
            foreach (var cashier in query)
            {
                cboCashiers.Items.Add(cashier);
            }

            var query3 = from c in TravelAgenceMasterClass.getTravelAgencyContext().BankAccounts
                         select c;
            cboBankAccounts.ValueMember = "AccountNumber";
            foreach (var bankAccount in query3)
            {
                cboBankAccounts.Items.Add(bankAccount);
            }


            var query4 = from c in TravelAgenceMasterClass.getTravelAgencyContext().PaymentTypes
                         select c;
            cboPaymentTypes.ValueMember = "Name";
            foreach (var paymentType in query4)
            {
                cboPaymentTypes.Items.Add(paymentType);
            }

            var query5 = from c in TravelAgenceMasterClass.getTravelAgencyContext().Currencies
                         select c;
            cboCurrencies.ValueMember = "Name";
            foreach (var bankAccount in query5)
            {
                cboCurrencies.Items.Add(bankAccount);
            }
        }

        private void cboPaymentTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            PaymentType paymentType = (PaymentType)cboPaymentTypes.SelectedItem;
            if (paymentType.IsBankOperation)
            {
                pnlBankAccount.Show();
                pnlCashier.Hide();
            }
            else
            {
                pnlBankAccount.Hide();
                pnlCashier.Show();
            }
        }

        private void cboCurrencies_SelectedIndexChanged(object sender, EventArgs e)
        {
            Currency currency = (Currency)cboCurrencies.SelectedItem;
            if (currency.CurrencyID == LE)
            {
                nudExchangeRate.Value = 1;
            }
            else
            {
                nudExchangeRate.Value = 0;
            }
        }

        public PaymentData validateAndGetPaymentData()
        {
            bool ExitSave = false;

            // payment type
            PaymentType paymentType = (PaymentType)cboPaymentTypes.SelectedItem;
            if (paymentType.IsBankOperation)
            {
                // bank account
                if (cboBankAccounts.SelectedItem == null)
                {
                    errProvider.SetError(cboBankAccounts, "Required Field");
                    ExitSave = true;
                }
                else
                {
                    errProvider.SetError(cboBankAccounts, "");
                }
            }
            else
            {
                // Cashier
                if (cboCashiers.SelectedItem == null)
                {
                    errProvider.SetError(cboCashiers, "Required Field");
                    ExitSave = true;
                }
                else
                {
                    errProvider.SetError(cboCashiers, "");
                }

            }

            if (nudAmount.Value == 0)
            {
                errProvider.SetError(nudAmount, "Can't be zero");
                ExitSave = true;
            }
            else
            {
                errProvider.SetError(nudAmount, "");
            }

            if (nudExchangeRate.Value == 0)
            {
                errProvider.SetError(nudExchangeRate, "Can't be zero");
                ExitSave = true;
            }
            else
            {
                errProvider.SetError(nudExchangeRate, "");
            }

            if (checkAvailblity && !ExitSave)
            {
                LedgerAccount current = null;
                if (paymentType.IsBankOperation)
                {
                   current= ((BankAccount)cboBankAccounts.SelectedItem).LedgerAccounts.ElementAt(0);
                }
                else
                {
                    current= ((Cashier)cboCashiers.SelectedItem).LedgerAccounts.ElementAt(0);
                }
                //TravelAgenceMasterClass.getTravelAgencyContext().
            }

            if (!ExitSave)
            {
                PaymentData paymentData = new PaymentData();
                paymentData.Amount = nudAmount.Value;
                paymentData.PaymentType = paymentType;
                paymentData.Currency = (Currency)cboCurrencies.SelectedItem;
                paymentData.ExchangeRate = nudExchangeRate.Value;
                if (paymentType.IsBankOperation)
                {
                    paymentData.BankAccount = (BankAccount)cboBankAccounts.SelectedItem;
                }
                else
                {
                    paymentData.Cashier = (Cashier)cboCashiers.SelectedItem;
                }
                return paymentData;
            }
            return null;
        }
    }
}
