using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TextForum.Models;
using TextForum.Models.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;

namespace TextForum.Controllers
{
    [Authorize]
    public class AdminController : Controller
    {
        private IPostRepository repository;
        private readonly RoleManager<IdentityRole> roleManager;
        public AdminController(RoleManager<IdentityRole> roleManager, IPostRepository repo)
        {
            this.roleManager = roleManager;
            repository = repo;
        }

        [HttpGet]
        public IActionResult CreateRole()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateRole(CreateRoleViewModel model)
        {
            if (ModelState.IsValid)
            {
                IdentityRole identityRole = new IdentityRole
                {
                    Name = model.RoleName
                };
                IdentityResult result = await roleManager.CreateAsync(identityRole);


                if (result.Succeeded)
                {
                    return RedirectToAction("ListRoles", "Admin");
                }

                foreach (IdentityError error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
            }

            return View(model);
        }

        [HttpGet]
        public IActionResult ListRoles()
        {
            var roles = roleManager.Roles;
            return View(roles);
        }

        public ViewResult Index()
        {
            return View(
                new AdminListViewModel
                {
                    Posts = repository.Posts,
                    Replies = repository.Replies
                }
            );
        }

        [HttpPost]
        public IActionResult DeleteP(int postID)
        {
            repository.DeletePost(postID);
            repository.DeletePostReply(postID);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult DeleteR(int postID)
        {
            repository.DeleteReply(postID);
            return RedirectToAction("Index");
        }
    }
}