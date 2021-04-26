using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolManagementSystem.Data
{
    public class Parents
    {
        [Key]
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
