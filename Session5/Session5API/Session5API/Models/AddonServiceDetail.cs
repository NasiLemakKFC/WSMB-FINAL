//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Session5API.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class AddonServiceDetail
    {
        public long ID { get; set; }
        public System.Guid GUID { get; set; }
        public long AddonServiceID { get; set; }
        public long ServiceID { get; set; }
        public decimal Price { get; set; }
        public System.DateTime FromDate { get; set; }
        public string Notes { get; set; }
        public long NumberOfPeople { get; set; }
        public bool isRefund { get; set; }
    
        public virtual AddonService AddonService { get; set; }
        public virtual Service Service { get; set; }
    }
}
