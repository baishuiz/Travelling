//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class ZoneHotelMapping
    {
        public int Id { get; set; }
        public Nullable<int> ZoneID { get; set; }
        public string HotelID { get; set; }
        public Nullable<System.DateTime> LastMofifyTime { get; set; }
    
        public virtual Hotel Hotel { get; set; }
        public virtual Zone Zone { get; set; }
    }
}
