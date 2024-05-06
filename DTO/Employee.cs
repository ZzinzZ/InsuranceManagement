using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Employee
    {
        public string UserId { get; set; }
        public string Email { get; set; }
        public string EmployName { get; set; }
        public byte[] Password { get; set; }
        public string RoleId { get; set; }
        public string InsuranceTypeId { get; set; }
    }
}
