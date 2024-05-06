using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Invoice
    {
        public string InvoiceId { get; set; }
        public DateTime CreateDay { get; set; }
        public string AccountantId { get; set; }
        public string ContractId { get; set; }
        public decimal Total { get; set; }
    }
}
