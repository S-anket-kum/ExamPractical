using ExamPractical.Models;
using Microsoft.AspNetCore.Mvc;

namespace ExamPractical.Controllers
{
    public class HelloController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Student()
        {
            Student student = new Student
            {
                Id = 1,
                Name = "Sanket",
                Gender = "Male"
            };

            ViewBag.CurrentDate = DateTime.Now.ToShortDateString();
            ViewData["Title"] = "Mr. Sanket Kumar";
            string? location = Convert.ToString(TempData["Location"]);


            return View(student);
        }
    }
}
