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
    
    public partial class Position
    {
        public int Id { get; set; }
        public string HotelID { get; set; }
        public Nullable<decimal> Latitude { get; set; }
        public Nullable<decimal> Longitude { get; set; }
        public Nullable<int> PositionTypeCode { get; set; }
        public Nullable<System.DateTime> LastMofifyTime { get; set; }
    
        public virtual Hotel Hotel { get; set; }
    }
}
