using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using BakedGoods.Models;
using System.Threading.Tasks;
using BakedGoods.ViewModels;

namespace ToDoList.Controllers
{
    public class AccountController : Controller
    {
        private readonly BakedGoodsContext _db;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;

        public AccountController (UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, BakedGoodsContext db)
        {
          _userManager = userManager;
          _signInManager = signInManager;
          _db = db;
        }

        public ActionResult Index()
        {
          return View();
        }

        public IActionResult Register()
        {
          return View();
        }

        public ActionResult Login()
        {
          return View();
        }

        [HttpPost]
        public async Task<ActionResult> Login(LoginViewModel model)
        {
          Microsoft.AspNetCore.Identity.SignInResult result = await _signInManager.PasswordSignInAsync(model.Email, model.Password, isPersistent: true, lockoutOnFailure: false);
          if (result.Succeeded)
          {
            return RedirectToAction("Index");
          }
          else
          {
            return View();
          }
        }

        [HttpPost]
        public async Task<ActionResult> LogOff()
        {
          await _signInManager.SignOutAsync();
          return RedirectToAction("Index");
        }

      [HttpPost]
      public async Task<ActionResult> Register (RegisterViewModel model)
      {
        var user = new ApplicationUser { UserName = model.Email };
        IdentityResult result = await _userManager.CreateAsync(user, model.Password);
        if (result.Succeeded)
        {
          return RedirectToAction("Index");
        }
        else
        {
          return View();
        }
      }
    }
}