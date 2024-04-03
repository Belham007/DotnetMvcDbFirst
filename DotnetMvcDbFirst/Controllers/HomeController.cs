using DotnetMvcDbFirst.Filters;
using DotnetMvcDbFirst.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DotnetMvcDbFirst.Controllers
{
  //  [CustomExceptionFilter]
    [CustomAuthenticationFilter]
    public class HomeController : Controller
    {
         readonly IUserMasterRepository userRepository;
        public HomeController(IUserMasterRepository repository)
        {
            this.userRepository = repository;
        }
        [CustomAuthorize("Normal", "SuperAdmin")]
        public ActionResult Index()
        {
           // var d = 0;
           // var c = 10 / d;
            return View();
        }

        [CustomAuthorize("Admin", "SuperAdmin")]
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        [CustomAuthorize("SuperAdmin")]
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult UnAuthorized()
        {
            ViewBag.Message = "Un Authorized Page!";

            return View();
        }
    }

  
}