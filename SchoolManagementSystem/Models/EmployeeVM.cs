using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolManagementSystem.Models
{
    public class EmployeeVM
    {
        public string UserName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public String FirstName { get; set; }
        public String MidddleName { get; set; }
        public String LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public String TaxId { get; set; }
    }
}
