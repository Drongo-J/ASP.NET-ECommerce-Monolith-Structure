using ECommerce.WebUI.ExtensionMethod;
using ECommerce.WebUI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ECommerce.WebUI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        #region Session
        //public string Index()
        //{
        //    HttpContext.Session.SetInt32("age", 25);
        //    HttpContext.Session.SetString("name", "John Johnlu");

        //    var student = new StudentTest()
        //    {
        //        Id = 1,
        //        Name = "Leyla",
        //        Surname = "Leylali"
        //    };
        //    HttpContext.Session.SetObject("student", student);
        //    return "SESSION CREATED";
        //}

        //public string GetSession()
        //{
        //    return $"AGE {HttpContext.Session.GetInt32("age")} \n NAME {HttpContext.Session.GetString("name")}";
        //}

        //public string GetStudent()
        //{
        //    var item = HttpContext.Session.GetObject<StudentTest>("student");
        //    return $"{item.Id} - {item.Name} - {item.Surname}";
        //}
        #endregion

        public string Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}