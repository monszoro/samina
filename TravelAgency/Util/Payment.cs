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
            // Save changes 
            TravelAgenceMasterClass.TravelAgencyContext.LedgerTransactions.Add(ledgerTransaction);
            TravelAgenceMasterClass.TravelAgencyContext.SaveChanges();
            TravelAgenceMasterClass.resetTravelAgencyEntities();
            // credit client
            LedgerTransactionDetail clientTransactionDetail = new LedgerTransactionDetail();
            clientTransactionDetail.LedgerTransactionID = ledgerTransaction.LedgerTransactionID;
            clientTransactionDetail.Amount=reservation.NetPrice;
            clientTransactionDetail.CurrencyID=0;
            clientTransactionDetail.ExchangeRate= 1;
            clientTransactionDetail.LedgerAccount=reservation.Client.LedgerAccounts.ElementAt(0);
            clientTransactionDetail.LedgerTransactionTypeID = (int)TransactionType.Credit;
            TravelAgenceMasterClass.TravelAgencyContext.LedgerTransactionDetails.Add(clientTransactionDetail);
            TravelAgenceMasterClass.TravelAgencyContext.SaveChanges();
            // debit vendor 
            LedgerTransactionDetail vendorTransactionDetail = new LedgerTransactionDetail();
            vendorTransactionDetail.LedgerTransactionID = ledgerTransaction.LedgerTransactionID;
            vendorTransactionDetail.Amount = reservation.BasicPrice + reservation.Taxes;
            vendorTransactionDetail.CurrencyID = 0;
            vendorTransactionDetail.ExchangeRate = 1;
            vendorTransactionDetail.LedgerAccount = reservation.Vendor.LedgerAccounts.ElementAt(0);
            vendorTransactionDetail.LedgerTransactionTypeID = (int)TransactionType.Debit;
            TravelAgenceMasterClass.TravelAgencyContext.LedgerTransactionDetails.Add(vendorTransactionDetail);
            TravelAgenceMasterClass.TravelAgencyContext.SaveChanges();
            // debit eslam 
            LedgerTransactionDetail thisCompanyTransactionDetail = new LedgerTransactionDetail();
            thisCompanyTransactionDetail.LedgerTransactionID = ledgerTransaction.LedgerTransactionID;
            thisCompanyTransactionDetail.Amount = reservation.Commission;
            thisCompanyTransactionDetail.CurrencyID = 0;
            thisCompanyTransactionDetail.ExchangeRate = 1;
            thisCompanyTransactionDetail.LedgerAccount = reservation.Vendor.LedgerAccounts.ElementAt(0);
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
