//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsFormsApplication
{
    using System;
    using System.Collections.Generic;
    
    public partial class Supplier
    {
        public Supplier()
        {
            this.Products = new HashSet<Product>();
            this.ProposeReceipts = new HashSet<ProposeReceipt>();
        }
    
        public string SupplierID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
    
        public virtual ICollection<Product> Products { get; set; }
        public virtual ICollection<ProposeReceipt> ProposeReceipts { get; set; }
    }
}
