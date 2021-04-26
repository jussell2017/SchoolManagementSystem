using SchoolManagementSystem.Contracts;
using SchoolManagementSystem.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolManagementSystem.Repository
{
    public class StudentRepository : IStudentRepository
    {
        private readonly ApplicationDbContext _db;

        public StudentRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public bool Create(Student entity)
        {
            _db.Students.Add(entity);
            return Save();
        }

        public bool Delete(Student entity)
        {
            _db.Students.Remove(entity);
            return Save();
        }

        public ICollection<Student> FindAll()
        {
          var Students = _db.Students.ToList();
          return Students;
        }

        public Student FindById(int id)
        {
            var Student = _db.Students.Find(id);
            return Student;
        }

        public bool Save()
        {
            var changes = _db.SaveChanges();
            return changes > 0;
        }

        public bool Update(Student entity)
        {
            _db.Students.Update(entity);
            return Save();
        }
    }
}
