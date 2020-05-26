using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using EZurnals.Logic;
using EZurnals.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Internal;

namespace EZurnals.Controllers
{
    public class GradeController : Controller
    {
        public IActionResult IndexG()
        {
            var model = GradeManager.GetAll().Select(u => u.ToModel()).ToList();
            return View(model);
        }
        public IActionResult ViewSubjectGrades(string name)
        {
            //kad meklēja pēc id:
            //var model = GradeManager.GetSubjectGrades(oSubjectId).Select(u => u.ToModel()).ToList();
            var model=GradeManager.GetSubjectGrades(name).Select(u => u.ToModel()).ToList();
            return View(model);
        }

        public IActionResult AddG()
        {
            var model = new GradeModel();
            return View(model);
        }
        [HttpPost]
        public IActionResult AddG(GradeModel model)
        {
            if (ModelState.IsValid)
            {
                var student = StudentManager.GetAll().FirstOrDefault(c => c.Name == model.StudentName && c.Surname == model.StudentSurname);
                var subject = SubjectManager.GetAll().FirstOrDefault(c => c.Name == model.SubjectName);
                //model.Subject = SubjectController.Subjects.Find(s => s.Name == model.SubjectName);
                //model.Student = StudentController.Students.Find(s => s.Name == model.StudentName && s.Surname == model.StudentSurname);
                if (student == null)
                {
                    ModelState.AddModelError("stu", "Skolnieks nav atrasts!");
                }
                else if(subject == null)
                {
                    ModelState.AddModelError("sub", "Priekšmets nav atrasts!");
                }
                else if(model.Grade <1 || model.Grade > 10)
                {
                    ModelState.AddModelError("gra", "Atzīmei jābūt intervālā no 1 līdz 10!");
                }
                else
                {
                    GradeManager.Create(model.Grade, model.Comment, student.Id, subject.Id);
                    return RedirectToAction(nameof(IndexG));
                }
            }
            return View(model);
        }
    }
}