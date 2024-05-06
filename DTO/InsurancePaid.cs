using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class InsurancePaid
    {
        public string ContractId { get; set; }
        public DateTime LastPaymentDate { get; set; }
        public DateTime NextPaymentDueDate { get; set; }
        public decimal TotalPaid { get; set; }
        public int NumberOfPayments { get; set; }
    }
}
