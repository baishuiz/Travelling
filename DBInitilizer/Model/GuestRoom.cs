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
    
    public partial class GuestRoom
    {
        public GuestRoom()
        {
            this.RMARoomMappings = new HashSet<RMARoomMapping>();
            this.RoomExtensions = new HashSet<RoomExtension>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public string HotelID { get; set; }
        public Nullable<int> StandardOccupancy { get; set; }
        public string Size { get; set; }
        public Nullable<int> RoomTypeCode { get; set; }
        public string Floor { get; set; }
        public Nullable<int> BedTypeCode { get; set; }
        public Nullable<int> Quantity { get; set; }
        public string FeatureDescription { get; set; }
        public Nullable<int> InvBlockCode { get; set; }
        public Nullable<int> NonSmoking { get; set; }
        public string RoomSize { get; set; }
        public Nullable<int> HasWindow { get; set; }
        public Nullable<System.DateTime> LastMofifyTime { get; set; }
    
        public virtual Hotel Hotel { get; set; }
        public virtual ICollection<RMARoomMapping> RMARoomMappings { get; set; }
        public virtual ICollection<RoomExtension> RoomExtensions { get; set; }
    }
}
