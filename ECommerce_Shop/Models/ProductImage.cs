//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ECommerce_Shop.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class ProductImage
    {
        public long ProductImageId { get; set; }
        public long ProductId { get; set; }
        public string ImageName { get; set; }
        public bool CoverImage { get; set; }
    
        public virtual Product Product { get; set; }
    }
}
