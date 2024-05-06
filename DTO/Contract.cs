using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Contract
    {
        public string ContractId { get; set; }
        public string CreatorId { get; set; }
        public string CustomerId { get; set; }
        public string InsuranceTypeId { get; set; }
        public int TermLength { get; set; }
        public DateTime StartDay { get; set; }
        public DateTime EndDay { get; set; }
        public decimal TotalPrice { get; set; }
        public string PaymentType { get; set; }
        public string Status { get; set; }
        public byte[] Signature { get; set; }

        // Hàm khởi tạo mặc định không tham số
        public Contract()
        {
            // Khởi tạo các giá trị mặc định cho các thuộc tính
            ContractId = "";
            CreatorId = "";
            CustomerId = "";
            InsuranceTypeId = "";
            TermLength = 0;
            StartDay = DateTime.MinValue;
            EndDay = DateTime.MinValue;
            TotalPrice = 0;
            PaymentType = "";
            Status = "";
            Signature = null;
        }
    }

}
