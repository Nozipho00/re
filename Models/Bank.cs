//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OM_dummy1.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Bank
    {
        public string BranchCode { get; set; }
        public string BankName { get; set; }
        public string BankType { get; set; }
        public Nullable<int> CustomerID { get; set; }
        public Nullable<int> PolicyID { get; set; }
    
        public virtual Customer Customer { get; set; }
        public virtual Policy Policy { get; set; }
    }
}
