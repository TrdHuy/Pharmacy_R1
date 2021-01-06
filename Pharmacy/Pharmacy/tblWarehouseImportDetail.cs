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
    
    public partial class tblWarehouseImportDetail
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblWarehouseImportDetail()
        {
            this.tblOrderDetails = new HashSet<tblOrderDetail>();
        }
    
        public long ImportDetailID { get; set; }
        public string MedicineID { get; set; }
        public double Quantity { get; set; }
        public double QuantityUsed { get; set; }
        public System.DateTime ExpiredDate { get; set; }
        public decimal Price { get; set; }
        public long ImportID { get; set; }
        public bool IsActive { get; set; }
    
        public virtual tblMedicine tblMedicine { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblOrderDetail> tblOrderDetails { get; set; }
        public virtual tblWarehouseImport tblWarehouseImport { get; set; }
    }
}