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
    
    public partial class tblOtherPayment
    {
        public long PaymentID { get; set; }
        public System.DateTime PaymentTime { get; set; }
        public int PaymentType { get; set; }
        public string PaymentContent { get; set; }
        public decimal TotalPrice { get; set; }
        public bool IsActive { get; set; }
    }
}