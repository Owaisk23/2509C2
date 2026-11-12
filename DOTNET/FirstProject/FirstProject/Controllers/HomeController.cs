using FirstProject.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace FirstProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        [HttpGet]
        public IActionResult Index()
        {
            //TempData["CompanyName"] = "APTECH LEARNING PAKISTAN";
            //TempData.Keep();
            return View();
        }

        [HttpPost]
        public IActionResult Index(string email, string pwd)
        {
            if(email == "admin@aptech.com" && pwd == "aptech")
            {
                TempData["email"] = "Hello " + email;
                TempData.Keep();

                return RedirectToAction("Privacy");
            }
            return View();
        }
        public IActionResult Products()
        {
            return View();
        }
        public IActionResult About()
        {
            ViewBag.userName = "Ashar Ahmed";
            ViewBag.userDesignation = "Software Engineer";
            
            return View();
        }
        
        public IActionResult Contact()
        {
            ViewData["Address"] = "North Nazimabad Block A";
            return View();
        }

        public IActionResult Privacy()
        {
            TempData.Keep();
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
