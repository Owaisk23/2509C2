using Microsoft.AspNetCore.Mvc;

namespace SessionAuthentication.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            //return View();
            if (HttpContext.Session.GetString("role") == "admin")
            {

                return View();
            }
            else
            {
                return RedirectToAction("Login");
            }
        }

        public IActionResult Login()
        {
            return View();
        }

        //[HttpPost]
        //public IActionResult Login(string email, string pass)
        //{
        //    if (email == "admin@gmail.com" && pass == "admin")
        //    {
        //        HttpContext.Session.SetString("role", "admin");
        //        HttpContext.Session.SetString("email", email);
        //        RedirectToAction("Index");

        //    }
        //    else if (email == "user@gmail.com" && pass == "123")
        //    {
        //        HttpContext.Session.SetString("role", "user");
        //        HttpContext.Session.SetString("email", email);
        //        RedirectToAction("Index", "Home");
        //    }
        //    else if (email == "client@gmail.com" && pass == "123")
        //    {
        //        HttpContext.Session.SetString("role", "client");
        //        HttpContext.Session.SetString("email", email);
        //        RedirectToAction("Index", "Client");
        //    }
        //    else
        //    {
        //        ViewBag.msg = "Invalid Credentials";
        //        return View();
        //    }
        //}
    }
}
