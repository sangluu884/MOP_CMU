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
    
    public partial class BranchOfficeReceipt
    {
        public BranchOfficeReceipt()
        {
            this.BranchOfficeReceiptDetails = new HashSet<BranchOfficeReceiptDetail>();
        }
    
        public string BranchOfficeID { get; set; }
        public string HeadquaterID { get; set; }
        public System.DateTime Date { get; set; }
        public string Branch { get; set; }
        public string AccountID { get; set; }
    
        public virtual Account Account { get; set; }
        public virtual HeadquaterReceipt HeadquaterReceipt { get; set; }
        public virtual ICollection<BranchOfficeReceiptDetail> BranchOfficeReceiptDetails { get; set; }
    }
}