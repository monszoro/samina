﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TravelAgency.Util;

namespace TravelAgency
{
    public partial class ClientRefund : Form
    {
        static int LE = 1;

        public ClientRefund()
        {
            InitializeComponent();
            LoadComboBoxes();
            cboPaymentTypes.SelectedIndex = 0;
            cboCurrencies.SelectedIndex = 0;
        }

        private void LoadComboBoxes()
        {
           
            var query = from c in TravelAgenceMasterClass.TravelAgencyContext.Cashiers 
                        select c;
            cboCashiers.ValueMember = "Name";
            foreach (var cashier in query)
            {
                cboCashiers.Items.Add(cashier);
            }


            var query2 = from c in TravelAgenceMasterClass.TravelAgencyContext.Clients
                        select c;
            cboClients.ValueMember = "FullName";
            foreach (var client in query2)
            {
                cboClients.Items.Add(client);
            }


            var query3 = from c in TravelAgenceMasterClass.TravelAgencyContext.BankAccounts
                        select c;
            cboBankAccounts.ValueMember = "AccountNumber";
            foreach (var bankAccount in query3)
            {
                cboBankAccounts.Items.Add(bankAccount);
            }


            var query4 = from c in TravelAgenceMasterClass.TravelAgencyContext.PaymentTypes
                         select c;
            cboPaymentTypes.ValueMember = "Name";
            foreach (var paymentType in query4)
            {
                cboPaymentTypes.Items.Add(paymentType);
            }

            var query5 = from c in TravelAgenceMasterClass.TravelAgencyContext.Currencies
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
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            bool ExitSave = false;

            //Clients
            if (cboClients.SelectedItem == null)
            {
                errProvider.SetError(cboClients, "Required Field");
                ExitSave = true;
            }
            else
            {
                errProvider.SetError(cboClients, "");
            }

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

            if (!ExitSave)
            {

                Client client = (Client)cboClients.SelectedItem;
                PaymentData paymentData = new PaymentData();
                paymentData.Amount = nudAmount.Value;
                paymentData.PaymentType = paymentType;
                paymentData.Currency = (Currency)cboCurrencies.SelectedItem;
                paymentData.ExchangeRate = nudExchangeRate.Value;

                if (paymentType.IsBankOperation)
                {
                    Payment.bankAccountToClient((BankAccount)cboBankAccounts.SelectedItem,client,paymentData);
                }
                else
                {
                    Payment.cashierToClient((Cashier)cboCashiers.SelectedItem,client,  paymentData);
                }
                Close();
            }
        }
        
        
    }
}