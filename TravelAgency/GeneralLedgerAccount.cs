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
    
    public partial class GeneralLedgerAccount
    {
        public GeneralLedgerAccount()
        {
            this.LedgerAccounts = new HashSet<LedgerAccount>();
        }
    
        public int GeneralLedgerAccountID { get; set; }
        public string Name { get; set; }
        public int LedgerAccountTypeID { get; set; }
        public System.DateTime DateCreated { get; set; }
    
        public virtual ICollection<LedgerAccount> LedgerAccounts { get; set; }
    }
}
