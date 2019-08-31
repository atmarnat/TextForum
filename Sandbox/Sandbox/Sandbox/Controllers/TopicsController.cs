using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Sandbox.Controllers
{
    public class TopicsController : Controller
    {
        [HttpGet]
        public IActionResult Entertainment()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Fashion()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Fitness()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Food()
        {
            return View();
        }
        [HttpGet]
        public IActionResult History()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Language()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Literature()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Math()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Miscellaneous()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Places()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Social()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Sports()
        {
            return View();
        }
    }
}
