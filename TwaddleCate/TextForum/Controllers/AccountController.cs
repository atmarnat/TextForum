using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using TextForum.Models;
using TextForum.Models.ViewModels;

namespace TextForum.Controllers
{
    [Authorize]
    public class AccountController : Controller
    {
        private IPostRepository repository;
        private UserManager<IdentityUser> userManager;
        private SignInManager<IdentityUser> signInManager;
        public AccountController(UserManager<IdentityUser> userMgr, IPostRepository repo,
        SignInManager<IdentityUser> signInMgr)
        {
            userManager = userMgr;
            signInManager = signInMgr;
            repository = repo;
        }
        [AllowAnonymous]
        public ViewResult Login(string returnUrl)
        {
            return View(new LoginModel
            {
                ReturnUrl = returnUrl
            });
        }
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginModel loginModel)
        {
            if (ModelState.IsValid)
            {
                IdentityUser user =
                await userManager.FindByNameAsync(loginModel.Name);
                if (user != null)
                {
                    await signInManager.SignOutAsync();
                    if ((await signInManager.PasswordSignInAsync(user,
                    loginModel.Password, false, false)).Succeeded)
                    {
                        return Redirect(loginModel?.ReturnUrl ?? "/Index/Home");
                    }
                }
            }
            ModelState.AddModelError("", "Invalid name or password");
            return View(loginModel);
        }
        public async Task<RedirectResult> Logout(string returnUrl = "/")
        {
            await signInManager.SignOutAsync();
            return Redirect(returnUrl);
        }

        [AllowAnonymous]
        public ViewResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [AllowAnonymous]
        public async Task<IActionResult> Register(RegisterViewModel registerViewModel)
        {
            if (ModelState.IsValid)
            {
                IdentityUser user = new IdentityUser { UserName = registerViewModel.UserName, Email = registerViewModel.Email};
                IdentityResult result = await userManager.CreateAsync(user, registerViewModel.Password);
                if (result.Succeeded)
                {
                    //await signIn.SignInAsync(user, isPersistent: false);
                    return RedirectToAction("login", "account");
                }
                foreach (IdentityError error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
            }
            return View(registerViewModel);
        }


        [Authorize]
        public ViewResult Index()
        {
            var currentUser = User.FindFirstValue(ClaimTypes.Name);
            return View(
                new AdminListViewModel
                {
                    Posts = repository.Posts
                    .Where(p => p.UserName == currentUser),
                    Replies = repository.Replies
                    .Where(p => p.UserName == currentUser)
                }
            );
        }
    }
}
