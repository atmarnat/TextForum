using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Sandbox.Controllers
{
    public class TopicsController : Controller
    {
        // GET: /<controller>/
        //Food, Sports, Fashion, Programming, Health, Entertainment, Miscellaneous
        [HttpGet]
        public IActionResult Food()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Sports()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Fashion()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Programming()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Health()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Entertainment()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Miscellaneous()
        {
            return View();
        }
    }
}
