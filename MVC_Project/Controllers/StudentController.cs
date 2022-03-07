using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MVC_Project.Models;

namespace MVC_Project.Controllers
{
    public class StudentController : Controller
    {
        private ApplicationDbContext dbContext;
        public StudentController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public IActionResult Index()
        {
            List<Locations>
                locations = dbContext.Locations.ToList();
            return View(locations);
        }
        public IActionResult StudentList(int Id)
        {
            List<Students> students = dbContext.Students.Where(e =>
              e.Locations.Id == Id).ToList();
            return View(students);
        }
    }
}
