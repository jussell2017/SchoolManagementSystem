using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SchoolManagementSystem.Contracts;
using SchoolManagementSystem.Data;
using SchoolManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolManagementSystem.Controllers
{
    public class StudentController : Controller
    {
        private readonly IStudentRepository _repo;
        private readonly IMapper _mapper;

        public StudentController(IStudentRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        // GET: StudentController
        public ActionResult Index()
        {
            var students = _repo.FindAll().ToList();
            var model = _mapper.Map<List<Student>, List<StudentVM>>(students);
            return View(model);
        }

        // GET: StudentController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: StudentController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: StudentController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(StudentDetailsVM mod)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View(mod);
                }
                var Student = _mapper.Map<Student>(mod);
              //  Student.DOB= DateTime.Now;

                var isSuccess = _repo.Create(Student);

                if (!isSuccess)
                {
                    ModelState.AddModelError("", "There might be an error!");
                    return View(mod);
                }

                return RedirectToAction(nameof(Index));
            }

            catch
            {
                ModelState.AddModelError("", "There might be an error!");
                return View(mod);
            }
        }

        // GET: StudentController/Edit/5
        public ActionResult Edit(int id)
        {
            if (!_repo.isExists(id))
            {
                return NotFound();
            }
            var Student = _repo.FindById(id);
            var mod = _mapper.Map<StudentDetailsVM>(Student);
            return View(mod);
        }

        // POST: StudentController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(StudentDetailsVM mod)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View(mod);
                }
                var Student = _mapper.Map<Student>(mod);               
                var isSuccess = _repo.Update(Student);

                if (!isSuccess)
                {
                    ModelState.AddModelError("", "There might be an error!");
                    return View(mod);
                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                ModelState.AddModelError("", "There might be an error!");
                return View();
            }
        }

        // GET: StudentController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: StudentController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(StudentDetailsVM mod)
        {
            try
            {

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
