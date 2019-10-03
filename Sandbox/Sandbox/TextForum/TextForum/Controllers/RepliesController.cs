using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TextForum.Models;

namespace TextForum.Controllers
{
    public class RepliesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public RepliesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Replies
        public IActionResult List()
        {
            return View();
        }

        // GET: Replies/Create
        public IActionResult Create()
        {
            return View();
        }
    }
}
