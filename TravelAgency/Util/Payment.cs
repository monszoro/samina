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
        public void clientAddCache()
        {

        }

    }
}
