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
    
    public partial class tblWarehouseImport
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblWarehouseImport()
        {
            this.tblWarehouseImportDetails = new HashSet<tblWarehouseImportDetail>();
        }
    
        public long ImportID { get; set; }
        public System.DateTime ImportTime { get; set; }
        public int SupplierID { get; set; }
        public decimal TotalPrice { get; set; }
        public decimal PurchasePrice { get; set; }
        public string ImportDescription { get; set; }
    
        public virtual tblSupplier tblSupplier { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblWarehouseImportDetail> tblWarehouseImportDetails { get; set; }
    }
}