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
    
    public partial class Price
    {
        public string ProductID { get; set; }
        public double Price1 { get; set; }
        public System.DateTime EffectiveDay { get; set; }
    
        public virtual Product Product { get; set; }
    }
}