//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Data_Entity_Layer
{
    using System;
    using System.Collections.Generic;
    
    public partial class Account
    {
        public int Id { get; set; }
        public string Month { get; set; }
        public Nullable<int> Total_cost { get; set; }
        public Nullable<int> Prevous_amount { get; set; }
        public Nullable<int> Total_amount { get; set; }
        public int Cost_id { get; set; }
    
        public virtual Cost Cost { get; set; }
    }
}