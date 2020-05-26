using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EZurnals.Logic;
using EZurnals.Models;
using Microsoft.AspNetCore.Mvc;

namespace EZurnals.Controllers
{
    public class SubjectController : Controller
    {
        public IActionResult Index()
        {
            var subjects = SubjectManager.GetAll().Select(u => u.ToModel()).ToList();
            return View(subjects);
        }


        public IActionResult Add()
        {
            var model = new SubjectModel();

            return View(model);
        }


        [HttpPost]
        public IActionResult Add(SubjectModel model)
        {
            if(ModelState.IsValid)
            {
                SubjectManager.Create(model.Name);

                return RedirectToAction(nameof(Index));// vai arī tikai  "Index"?
            }
            return View(model);
        }
    }
}