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
    
    public partial class Branch
    {
        public Branch()
        {
            this.Clients = new HashSet<Client>();
        }
    
        public int BranchID { get; set; }
        public string BranchName { get; set; }
        public string FilesPath { get; set; }
    
        public virtual ICollection<Client> Clients { get; set; }
    }
}