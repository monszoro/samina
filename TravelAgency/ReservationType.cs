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
    
    public partial class ReservationType
    {
        public ReservationType()
        {
            this.Reservations = new HashSet<Reservation>();
        }
    
        public int TypeId { get; set; }
        public string Description { get; set; }
    
        public virtual ICollection<Reservation> Reservations { get; set; }
    }
}
