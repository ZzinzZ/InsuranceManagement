using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TypeInsurance
    {
        public string InsuranceTypeId { get; set; }
        public string NameType { get; set; }
        public decimal CoverageAmount { get; set; }
        public decimal Deductible { get; set; }
        public decimal PremiumRate { get; set; }
        public decimal PolicyLimit { get; set; }
    }
}
