using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolManagementSystem.Data
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public DateTime DOB { get; set; }
        public char HeightFeet{ get; set; }
        public char HeightInches { get; set; }
        public string Address { get; set; }
        public string StudentEmail { get; set; }
        public string StudentPhoneNumber { get; set; }
        public string BirthEntryNum { get; set; }
        public string StudentId { get; set; }
        public string StudentGrade { get; set; }
        public string StudentClass { get; set; }
        public string StudentHouse { get; set; }
        public string StudentAdditionalInfo { get; set; }
    }
}  
