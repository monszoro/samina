//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Database
{
    using System;
    using System.Collections.Generic;
    
    public partial class LedgerTransactionType
    {
        public LedgerTransactionType()
        {
            this.LedgerTransactionDetails = new HashSet<LedgerTransactionDetail>();
        }
    
        public int LedgerTransactionTypeID { get; set; }
        public string Description { get; set; }
    
        public virtual ICollection<LedgerTransactionDetail> LedgerTransactionDetails { get; set; }
    }
}