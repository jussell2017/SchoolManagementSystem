using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolManagementSystem.Models
{
    public class ParentsVM
    {
        public int Id { get; set; }

        public String Parent1FirstName { get; set; }

        public String Parent1LastName { get; set; }
        public DateTime Parent1DOB { get; set; }
        public String Parent1Email { get; set; }
        public String Parent1PhoneNumber { get; set; }
        public String Parent2FirstName { get; set; }
        public String Parent2LastName { get; set; }
        public DateTime Parent2DOB { get; set; }
        public String Parent2Address { get; set; }
        public String Parent2Email { get; set; }
        public String Parent2PhoneNumber { get; set; }
    }
}
