﻿using System;
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
        public IActionResult Create(PeopleCreateVM viewModel)
        {
            if (!ModelState.IsValid)
            {
                return View(viewModel);
            }
            DataManager.AddPerson(viewModel);
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var person = DataManager.GetPerson(id);
            PeopleEditVM viewModel = new PeopleEditVM
            {
                Name = person.Name,
                Email = person.Email,
                Id = person.Id
            };
            return View(viewModel);
        }

        [HttpPost]
        public IActionResult Edit(PeopleEditVM viewModel)
        {
            if (!ModelState.IsValid)
            {
                return View(viewModel);
            }
            //Person person = new Person
            //{
            //    Name = viewModel.Name,
            //    Email = viewModel.Email,
            //};

            DataManager.EditPerson(viewModel);

            return RedirectToAction(nameof(Index));
        }
    }
}
