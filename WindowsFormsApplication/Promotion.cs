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
    
    public partial class Promotion
    {
        public string PromotionID { get; set; }
        public double PromotionPrice { get; set; }
        public System.DateTime StartDate { get; set; }
        public System.DateTime EndDate { get; set; }
        public string Content { get; set; }
        public string Image { get; set; }
        public string ProductID { get; set; }
    
        public virtual Product Product { get; set; }
    }
}
