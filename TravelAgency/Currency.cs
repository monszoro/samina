//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TravelAgency
{
    using System;
    using System.Collections.Generic;
    
    public partial class Currency
    {
        public Currency()
        {
            this.LedgerTransactionDetails = new HashSet<LedgerTransactionDetail>();
        }
    
        public int CurrencyID { get; set; }
        public string Name { get; set; }
        public string Sign { get; set; }
    
        public virtual ICollection<LedgerTransactionDetail> LedgerTransactionDetails { get; set; }
    }
}
