//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CosmeticSolutionSystem.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class SalesLine
    {
        public int SalesLineId { get; set; }
        public Nullable<int> SalesId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
    
        public virtual Product Product { get; set; }
        public virtual Sale Sale { get; set; }
    }
}