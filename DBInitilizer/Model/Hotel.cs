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
    
    public partial class Hotel
    {
        public Hotel()
        {
            this.Addresses = new HashSet<Address>();
            this.CategoryCodeHotelMappings = new HashSet<CategoryCodeHotelMapping>();
            this.GuestRooms = new HashSet<GuestRoom>();
            this.HACHATMappings = new HashSet<HACHATMapping>();
            this.HotelAwardMappings = new HashSet<HotelAwardMapping>();
            this.ImageItems = new HashSet<ImageItem>();
            this.PolicyInfoes = new HashSet<PolicyInfo>();
            this.Policies = new HashSet<Policy>();
            this.Positions = new HashSet<Position>();
            this.RefPoints = new HashSet<RefPoint>();
            this.TextItems = new HashSet<TextItem>();
            this.ZoneHotelMappings = new HashSet<ZoneHotelMapping>();
        }
    
        public string Id { get; set; }
        public Nullable<int> HotelCode { get; set; }
        public Nullable<int> BrandCode { get; set; }
        public Nullable<int> HotelCityCode { get; set; }
        public string HotelName { get; set; }
        public Nullable<int> AreaID { get; set; }
        public Nullable<System.DateTime> WhenBuilt { get; set; }
        public Nullable<System.DateTime> LastUpdated { get; set; }
        public Nullable<System.DateTime> LastMofifyTime { get; set; }
        public byte[] Timestamp { get; set; }
    
        public virtual ICollection<Address> Addresses { get; set; }
        public virtual ICollection<CategoryCodeHotelMapping> CategoryCodeHotelMappings { get; set; }
        public virtual ICollection<GuestRoom> GuestRooms { get; set; }
        public virtual ICollection<HACHATMapping> HACHATMappings { get; set; }
        public virtual ICollection<HotelAwardMapping> HotelAwardMappings { get; set; }
        public virtual ICollection<ImageItem> ImageItems { get; set; }
        public virtual ICollection<PolicyInfo> PolicyInfoes { get; set; }
        public virtual ICollection<Policy> Policies { get; set; }
        public virtual ICollection<Position> Positions { get; set; }
        public virtual ICollection<RefPoint> RefPoints { get; set; }
        public virtual ICollection<TextItem> TextItems { get; set; }
        public virtual ICollection<ZoneHotelMapping> ZoneHotelMappings { get; set; }
    }
}
