//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EnityFrameworkConsoleApp
{
    using System;
    using System.Collections.Generic;
    
    public partial class GoodsSize
    {
        public GoodsSize()
        {
            this.GoodsMotions = new HashSet<GoodsMotion>();
            this.GoodsPositions = new HashSet<GoodsPosition>();
        }
    
        public int Id { get; set; }
        public int GoodsId { get; set; }
        public string Size { get; set; }
    
        public virtual Good Good { get; set; }
        public virtual ICollection<GoodsMotion> GoodsMotions { get; set; }
        public virtual ICollection<GoodsPosition> GoodsPositions { get; set; }
    }
}
