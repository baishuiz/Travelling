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
    
    public partial class CancelPenalty
    {
        public int Id { get; set; }
        public Nullable<int> RateId { get; set; }
        public Nullable<System.DateTime> Start { get; set; }
        public Nullable<System.DateTime> End { get; set; }
        public Nullable<decimal> AmountPercent { get; set; }
        public string CurrencyCode { get; set; }
        public Nullable<decimal> OtherCurrencyAmount { get; set; }
        public string OtherCurrencyCode { get; set; }
        public Nullable<System.DateTime> LastModifyTime { get; set; }
    
        public virtual Rate Rate { get; set; }
    }
}
