using System;
using System.Collections.Generic;

namespace ShareT.Data.Entity
{
    public partial class ApplyInvoice
    {
        public int Id { get; set; }
        public int AccountId { get; set; }
        public int InvoiceType { get; set; }
        public bool? IsElectronic { get; set; }
        public bool IsEnterprise { get; set; }
        public string TaxNumber { get; set; }
        public string OrderDetail { get; set; }
        public int InvoiceStatus { get; set; }
        public decimal InvoiceAmount { get; set; }
        public string InvoiceHead { get; set; }
        public string ReceivePeople { get; set; }
        public string Phone { get; set; }
        public string Area { get; set; }
        public string DetailsAddress { get; set; }
        public string Remarks { get; set; }
        public DateTime? ApplyTime { get; set; }
        public DateTime CreateTime { get; set; }

        public Account Account { get; set; }
    }
}
