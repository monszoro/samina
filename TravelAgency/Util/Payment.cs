using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TravelAgency.Util
{
    public class Payment
    {
        private enum TransactionType
        {
            Debit = 1,
            Credit = 2
        }

        public static void createConfirmReservationTransaction(Reservation reservation)
        {
            
            LedgerTransaction ledgerTransaction = new LedgerTransaction();
            ledgerTransaction.Description = "Reservation no."+reservation.ReservationID+" is confirmed";
            ledgerTransaction.ReservationID = reservation.ReservationID;
            // Save changes 
            TravelAgenceMasterClass.TravelAgencyContext.LedgerTransactions.Add(ledgerTransaction);
            //TravelAgenceMasterClass.TravelAgencyContext.SaveChanges();

            // credit client
            LedgerTransactionDetail clientTransactionDetail = new LedgerTransactionDetail();
            clientTransactionDetail.LedgerTransaction = ledgerTransaction;
            clientTransactionDetail.Amount=reservation.NetPrice;
            clientTransactionDetail.LedgerAccount=reservation.Client.LedgerAccounts.ElementAt(0);
            clientTransactionDetail.LedgerTransactionTypeID = (int)TransactionType.Credit;
            TravelAgenceMasterClass.TravelAgencyContext.LedgerTransactionDetails.Add(clientTransactionDetail);

            // debit vendor 
            LedgerTransactionDetail vendorTransactionDetail = new LedgerTransactionDetail();
            vendorTransactionDetail.LedgerTransaction = ledgerTransaction;
            vendorTransactionDetail.Amount = reservation.BasicPrice + reservation.Taxes;
            vendorTransactionDetail.LedgerAccount = reservation.Vendor.LedgerAccounts.ElementAt(0);
            vendorTransactionDetail.LedgerTransactionTypeID = (int)TransactionType.Debit;
            TravelAgenceMasterClass.TravelAgencyContext.LedgerTransactionDetails.Add(vendorTransactionDetail);
           
            // debit eslam 
            LedgerTransactionDetail thisCompanyTransactionDetail = new LedgerTransactionDetail();
            thisCompanyTransactionDetail.LedgerTransaction = ledgerTransaction;
            thisCompanyTransactionDetail.Amount = reservation.Commission;
            thisCompanyTransactionDetail.LedgerAccountID = TravelAgenceMasterClass.MainAccountID;
            thisCompanyTransactionDetail.LedgerTransactionTypeID = (int)TransactionType.Debit;
            TravelAgenceMasterClass.TravelAgencyContext.LedgerTransactionDetails.Add(thisCompanyTransactionDetail);

            // Save changes 
            TravelAgenceMasterClass.TravelAgencyContext.SaveChanges();
        }

        public static void clientAddCacheToCashier(Client client, Cashier cashier, PaymentData paymentData)
        {
            String description = "Client ID. " + client.ClientID + " paid to Cashier ID. " + cashier.CashierID +" by "+ paymentData.PaymentType.Name;
            ledgerAccountToLedgerAccount(client.LedgerAccounts.ElementAt(0), cashier.LedgerAccounts.ElementAt(0),paymentData,description);
        }

        public static void clientAddCacheToBankAccount(Client client, BankAccount bankAccount, PaymentData paymentData)
        {
            String description = "Client ID. " + client.ClientID + " paid to bank Account ID. " + bankAccount.BankAccountID + " by " + paymentData.PaymentType.Name;
            ledgerAccountToLedgerAccount(client.LedgerAccounts.ElementAt(0), bankAccount.LedgerAccounts.ElementAt(0), paymentData, description); 
        }

        public static void cashierToClient(Cashier cashier, Client client, PaymentData paymentData)
        {
            String description = "Cashier ID. " + cashier.CashierID + " paid to Client ID. " + client.ClientID + " by " + paymentData.PaymentType.Name;
            ledgerAccountToLedgerAccount(cashier.LedgerAccounts.ElementAt(0), client.LedgerAccounts.ElementAt(0), paymentData, description);
        }

        public static void bankAccountToClient(BankAccount bankAccount, Client client, PaymentData paymentData)
        {
            String description = "Bank Account ID. " + bankAccount.BankAccountID + " paid to Client ID. " + client.ClientID + " by " + paymentData.PaymentType.Name;
            ledgerAccountToLedgerAccount(bankAccount.LedgerAccounts.ElementAt(0), client.LedgerAccounts.ElementAt(0), paymentData, description);
        }

        public static void cashierToVendor(Cashier cashier, Vendor vendor, PaymentData paymentData)
        {
            String description = "Cashier ID. " + cashier.CashierID + " paid to Vendor ID. " + vendor.VendorID + " by " + paymentData.PaymentType.Name;
            ledgerAccountToLedgerAccount(cashier.LedgerAccounts.ElementAt(0), vendor.LedgerAccounts.ElementAt(0), paymentData, description);
        }

        public static void bankAccountToVendor(BankAccount bankAccount, Vendor vendor, PaymentData paymentData)
        {
            String description = "Bank Account ID. " + bankAccount.BankAccountID + " paid to Vendor ID. " + vendor.VendorID + " by " + paymentData.PaymentType.Name;
            ledgerAccountToLedgerAccount(bankAccount.LedgerAccounts.ElementAt(0), vendor.LedgerAccounts.ElementAt(0), paymentData, description);
        }

        public static void cashierToExpens(Cashier cashier, Expens expens, PaymentData paymentData)
        {
            String description = "Cashier ID. " + cashier.CashierID + " paid to Expens ID. " + expens.ExpenseID + " by " + paymentData.PaymentType.Name;
            ledgerAccountToLedgerAccount(cashier.LedgerAccounts.ElementAt(0), expens.LedgerAccounts.ElementAt(0), paymentData, description);
        }

        public static void bankAccountToExpens(BankAccount bankAccount, Expens expens, PaymentData paymentData)
        {
            String description = "Bank Account ID. " + bankAccount.BankAccountID + " paid to Expens ID. " + expens.ExpenseID + " by " + paymentData.PaymentType.Name;
            ledgerAccountToLedgerAccount(bankAccount.LedgerAccounts.ElementAt(0), expens.LedgerAccounts.ElementAt(0), paymentData, description);
        }
        private static void ledgerAccountToLedgerAccount(LedgerAccount source, LedgerAccount destination, PaymentData paymentData, String description)
        {
            // Added finantial transaction record 
            FinantialTransaction finantialTransaction = new FinantialTransaction();
            finantialTransaction.Amount = paymentData.Amount;
            finantialTransaction.CreationDate = System.DateTime.Now;
            finantialTransaction.CreationUserID = TravelAgenceMasterClass.CurrentUser.UserID;
            finantialTransaction.CurrencyID = paymentData.Currency.CurrencyID;
            finantialTransaction.SourceAccountID = source.LedgerAccountID;
            finantialTransaction.DestinationAccountID = destination.LedgerAccountID;
            finantialTransaction.ExchangeRate = paymentData.ExchangeRate;
            finantialTransaction.PaymentTypeID = paymentData.PaymentType.PaymentTypeID;
            finantialTransaction.Description = description;
            //TravelAgenceMasterClass.TravelAgencyContext.FinantialTransactions.Add(finantialTransaction);

            // added ledger transaction records 
            LedgerTransaction ledgerTransaction = new LedgerTransaction();
            ledgerTransaction.Description = description;
            ledgerTransaction.FinantialTransaction = finantialTransaction;
            TravelAgenceMasterClass.TravelAgencyContext.LedgerTransactions.Add(ledgerTransaction);

            // debit client
            LedgerTransactionDetail clientTransactionDetail = new LedgerTransactionDetail();
            clientTransactionDetail.LedgerTransaction = ledgerTransaction;
            clientTransactionDetail.Amount = paymentData.Amount * paymentData.ExchangeRate;
            clientTransactionDetail.LedgerAccountID = source.LedgerAccountID;
            clientTransactionDetail.LedgerTransactionTypeID = (int)TransactionType.Debit;
            ledgerTransaction.LedgerTransactionDetails.Add(clientTransactionDetail);

            // credit Ledger Account 
            LedgerTransactionDetail leadgerTransactionDetail = new LedgerTransactionDetail();
            leadgerTransactionDetail.LedgerTransaction = ledgerTransaction;
            leadgerTransactionDetail.Amount = paymentData.Amount * paymentData.ExchangeRate;
            leadgerTransactionDetail.LedgerAccountID = destination.LedgerAccountID;
            leadgerTransactionDetail.LedgerTransactionTypeID = (int)TransactionType.Credit;
            ledgerTransaction.LedgerTransactionDetails.Add(leadgerTransactionDetail);
            // Save changes 
            TravelAgenceMasterClass.TravelAgencyContext.SaveChanges();
        }
    }
}
