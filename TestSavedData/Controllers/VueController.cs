using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TestSavedData.Models;

namespace TestSavedData.Controllers
{
    public class VueController : Controller
    {
        private readonly TestSavedDataContext _context;

        public VueController(TestSavedDataContext context)
        {
            _context = context;
        }

        [Route("/vue")]
        [HttpGet]
        public IActionResult Get()
        {
            Person p = new Person() { Id = 1, Name = "moji", age = 27 };
            //var model = _context.Person;
            return View();
        }

        [Route("/vue")]
        [HttpPost]
        public IActionResult Post(Person model)
        {
            _context.Person.Add(model);
            _context.SaveChanges();

            return Ok(model);
        }

        [Route("/vue")]
        [HttpPut]
        public IActionResult Put(Person model)
        {
            var person = _context.Person.Find(model.Id);
            person.Name = model.Name;
            person.age = model.age;

            _context.SaveChanges();

            return Ok(model);
        }

        [Route("/vue")]
        [HttpDelete]
        public IActionResult Delete(Person model)
        {
            var person = _context.Person.Find(model.Id);
            _context.Person.Remove(person);

            _context.SaveChanges();

            return Ok(model);
        }
    }
}
