using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Customer
    {
        public string CustomerId { get; set; }
        public string Email { get; set; }
        public byte[] Password { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public DateTime BirthDay { get; set; }
        public string WorkPlace { get; set; }
        public string PerAddress { get; set; }
        public string TempAddress { get; set; }
        public string MedicalHistory { get; set; }
        public byte[] HashInfomation { get; set; }
        public byte[] PublicKey { get; set; }

        public string RoleId { get; set; }
    }
}
