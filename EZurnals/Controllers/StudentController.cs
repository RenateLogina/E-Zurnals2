using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EZurnals.Logic;
using EZurnals.Models;
using Microsoft.AspNetCore.Mvc;

namespace EZurnals.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult IndexS()
        {
            var students = StudentManager.GetAll().Select(u => u.ToModel()).ToList();
            foreach(var stu in students)
            {
                var count = GradeManager.GetAll().Where(s => s.StudentId == stu.OStudentId).Select(u =>u.ToModel()).ToList();
                if (count.Count > 0)
                {
                    stu.AverageGrade = count.Select(s => s.Grade).Average();
                }
            }
            return View(students);
        }
        
        public IActionResult ViewStudentGrades(int oStudentId)
        {
            var model = StudentManager.GetGrades(oStudentId).ToModel(); // izvēlās konkrēto skolnieku pēc ID
            //var model = Students.Find(i => i.Name == name && i.Surname == surname);
            //TODO: pēc izvēlētā 
            model.Grades = GradeManager.GetAll().Where(u => u.StudentId == oStudentId).Select(u => u.ToModel()).ToList();
            //model.Grades = GradeController.Grades.Where(i => i.StudentName == name && i.StudentSurname == surname).ToList();
            if (model.Grades.Count > 0)
            {
                model.AverageGrade = model.Grades.Select(s => s.Grade).Average();
            }
            return View(model);
        }
        
        public IActionResult AddS()
        {
            var model = new StudentModel();
            return View(model);
        }
        [HttpPost]
        public IActionResult AddS(StudentModel model)
        {
            
            if (ModelState.IsValid)
            {
                StudentManager.Create(model.Name, model.Surname, model.Klase, model.BirthYear);
                return RedirectToAction(nameof(IndexS));
            }
            return View(model);
        }

    }
}