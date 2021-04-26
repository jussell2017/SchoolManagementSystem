using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolManagementSystem.Data
{
    public class Employee : IdentityUser
    {
        public String FirstName { get; set; }

        public String MidddleName { get; set; }
        public String LastName { get; set; }

        public DateTime DateOfBirth { get; set; }

        public String TaxId { get; set; }
    }
}
