using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        // GET: /HelloWorld/
        public IActionResult Index()
        {
            return View();
        }
        // GET: /HelloWorld/Welcome/ 
        public IActionResult Welcome(string name, int numTimes = 1)
        {
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;
            //The ViewData dictionary object contains data that will be passed to the view.
            //the ViewData dictionary was used to pass data from the controller to a view
            return View();
        }
    }
}
