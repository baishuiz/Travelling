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
    
    public partial class RoomPlanBookRuleMapping
    {
        public int Id { get; set; }
        public Nullable<int> BookRuleId { get; set; }
        public Nullable<int> RatePlanId { get; set; }
        public string Parameters { get; set; }
        public Nullable<System.DateTime> LastModifyTime { get; set; }
    
        public virtual BookRule BookRule { get; set; }
        public virtual RatePlan RatePlan { get; set; }
    }
}
