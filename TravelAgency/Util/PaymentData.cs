using Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace TravelAgency.Util
{
    public class PaymentData
    {
        public PaymentData() { }
        public decimal Amount { get; set; }

        public PaymentType PaymentType { get; set; }

        public Currency Currency { get; set; }

        public decimal ExchangeRate { get; set; }

        public BankAccount BankAccount { get; set; }

        public Cashier Cashier  { get; set; }
    }
}
