using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolManagementSystem.Models
{
    public class StudentVM
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public DateTime DOB { get; set; }
        public char HeightFeet { get; set; }
        public char HeightInches { get; set; }
        public string Address { get; set; }
        public string StudendEmail { get; set; }
        public string StudentPhoneNumber { get; set; }
        public char BirthEntryNum { get; set; }
        public char StudentId { get; set; }
        public char StudentGrade { get; set; }
        public char StudentClass { get; set; }
        public string StudentHouse { get; set; }
        public string StudentAdditionalInfo { get; set; }
    }
}
