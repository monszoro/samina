using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TravelAgency.Util;
using Database;
namespace TravelAgency
{
    public partial class ClientPayment : Form
    {
        static int LE = 1;

        public ClientPayment()
        {
            InitializeComponent();
            LoadComboBoxes();
            uc_accountCurrenciesAmount.loadControl(false);
        }

        private void LoadComboBoxes()
        {
            var query2 = from c in TravelAgenceMasterClass.getTravelAgencyContext().Clients
                         select c;
            cboClients.ValueMember = "FullName";
            foreach (var client in query2)
            {
                cboClients.Items.Add(client);
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

            PaymentData paymentData = uc_accountCurrenciesAmount.validateAndGetPaymentData();

            if (!ExitSave && paymentData != null)
            {

                Client client = (Client)cboClients.SelectedItem;

                if (paymentData.PaymentType.IsBankOperation)
                {
                    Payment.clientAddCacheToBankAccount(client, paymentData.BankAccount, paymentData);
                }
                else
                {
                    Payment.clientAddCacheToCashier(client, paymentData.Cashier, paymentData);
                }
                Close();
            }
        }


    }
}
