//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MyFinancialCrmm.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class BankProcesses
    {
        public int BankProcessId { get; set; }
        public string Description { get; set; }
        public Nullable<System.DateTime> ProcessData { get; set; }
        public string ProcessType { get; set; }
        public Nullable<decimal> Amoun { get; set; }
        public Nullable<int> BankId { get; set; }
    
        public virtual Banks Banks { get; set; }
    }
}
