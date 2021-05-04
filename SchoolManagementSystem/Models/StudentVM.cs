using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SchoolManagementSystem.Models
{
    public class StudentVM
    {
        public int Id { get; set; }
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Display(Name = "Middle Name")]
        public string MiddleName { get; set; }
        [Display(Name ="Last Name")]
        public string LastName { get; set; }
       /* [Display(Name ="Date Created")]
        public DateTime DateCreated { get; set; }*/             
       
    }
    public class StudentDetailsVM
    {
        public int Id { get; set; }
       
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public DateTime DOB { get; set; }
        public int HeightFeet { get; set; }
        public int HeightInches { get; set; }
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
