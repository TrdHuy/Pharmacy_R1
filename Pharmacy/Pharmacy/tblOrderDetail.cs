//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Pharmacy
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblOrderDetail
    {
        public long OrderDetailID { get; set; }
        public long ImportDetailID { get; set; }
        public double Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal TotalPrice { get; set; }
        public long OrderID { get; set; }
        public bool IsActive { get; set; }
    
        public virtual tblOrder tblOrder { get; set; }
        public virtual tblWarehouseImportDetail tblWarehouseImportDetail { get; set; }
    }
}