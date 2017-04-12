using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GruppArbete_Personer.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GruppArbete_Personer.Controllers
{
    public class PeopleController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            var persons = DataManager.GetAllPersons();
            return View(persons);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Person person)
        {
            if (!ModelState.IsValid)
            {
                return View(person);
            }
            DataManager.AddPerson(person);
            return RedirectToAction(nameof(Index));
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var person = DataManager.GetPerson(id);
            return View(person);
        }

        [HttpPost]
        public IActionResult Edit(Person person)
        {
            DataManager.EditPerson(person);

            return RedirectToAction(nameof(Index));
        }
    }
}
