using SchoolManagementSystem.Contracts;
using SchoolManagementSystem.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolManagementSystem.Repository
{
    public class ParentsRepository : IParentsRepository
    {
        private readonly ApplicationDbContext _db;

        public ParentsRepository(ApplicationDbContext db)
        {
            _db = db;
        }
        public bool Create(Parents entity)
        {
            _db.SParent.Add(entity);
            return Save();
        }

        public bool Delete(Parents entity)
        {
            _db.SParent.Remove(entity);
            return Save();
        }

        public ICollection<Parents> FindAll()
        {
            var SParent = _db.SParent.ToList();
            return SParent;
        }

        public Parents FindById(int id)
        {
            var Parent = _db.SParent.Find(id);
            return Parent;
        }

        public bool isExists(int id)
        {
            var exists = _db.SParent.Any(q => q.Id == id);
            return exists;
        }

        public bool Save()
        {
            var changes = _db.SaveChanges();
            return changes > 0;
        }

        public bool Update(Parents entity)
        {
            _db.SParent.Update(entity);
            return Save();
        }
    }
}
