//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Session4
{
    using System;
    using System.Collections.Generic;
    
    public partial class Transaction
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Transaction()
        {
            this.Bookings = new HashSet<Booking>();
        }
    
        public long ID { get; set; }
        public System.Guid GUID { get; set; }
        public long UserID { get; set; }
        public long TransactionTypeID { get; set; }
        public decimal Amount { get; set; }
        public System.DateTime TransactionDate { get; set; }
        public string GatewayReturnID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Booking> Bookings { get; set; }
        public virtual TransactionType TransactionType { get; set; }
    }
}
