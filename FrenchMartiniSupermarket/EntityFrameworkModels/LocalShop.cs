//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EntityFrameworkModels
{
    using System;
    using System.Collections.Generic;
    
    public partial class LocalShop
    {
        public LocalShop()
        {
            this.Reports = new HashSet<Report>();
        }
    
        public int LocalShopId { get; set; }
        public string LocalShopName { get; set; }
    
        public virtual ICollection<Report> Reports { get; set; }
    }
}