using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MvcMovie.Models;


namespace MvcMovie.Controllers
{
	
		[Route("[controller]/[action]")]
		public class AccountController : Controller
		{
			private readonly UserManager<ApplicationUser> _userManager;
			private readonly SignInManager<ApplicationUser> _signInManager;

			public AccountController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager)
			{
				_userManager = userManager;
				_signInManager = signInManager;
			}

	
			[HttpGet]
			[AllowAnonymous]
			public IActionResult Register(string returnUrl = null)
			{
				ViewData["ReturnUrl"] = returnUrl;
				return View();
			}

			//
			// POST: /Account/Register
			[HttpPost]
			[AllowAnonymous]
			[ValidateAntiForgeryToken]
			public async Task<IActionResult> Register(RegisterViewModel model)
			{
				if (ModelState.IsValid)
				{
					var user = new ApplicationUser { UserName = model.Email, Email = model.Email, NickName = model.NickName };
					var result = await _userManager.CreateAsync(user, model.Password);
					if (result.Succeeded)
					{
						await _signInManager.SignInAsync(user, isPersistent: false);
						return RedirectToAction("Index", "Home");
					}
					ModelState.AddModelError(string.Empty, "Invalid registration attempt.");
				}

				
				return View(model);
			}

			[HttpGet]
			[AllowAnonymous]
			public IActionResult Login(string returnUrl = null)
			{
				ViewData["ReturnUrl"] = returnUrl;
				return View();
			}

			[HttpPost]
			[AllowAnonymous]
			[ValidateAntiForgeryToken]
			public async Task<IActionResult> Login(LoginViewModel model, string returnUrl = null)
			{
				ViewData["ReturnUrl"] = returnUrl;
				if (ModelState.IsValid)
				{
					var result = await _signInManager.PasswordSignInAsync(model.Email, model.Password, isPersistent: false, lockoutOnFailure: false);
					if (result.Succeeded)
					{
						if (!string.IsNullOrEmpty(returnUrl))
						{
							return Redirect(returnUrl);
						}
						else
						{
							return RedirectToAction("Index", "Home");
						}
					}
					ModelState.AddModelError(string.Empty, "Invalid login attempt.");
					return View(model);
				}
				
				return View(model);
			}

			// POST: /Account/LogOut
			[HttpPost]
			[ValidateAntiForgeryToken]
			public async Task<IActionResult> LogOut()
			{
				await _signInManager.SignOutAsync();
				return RedirectToAction(nameof(HomeController.Index), "Home");
			}

		public IActionResult EditNickName()
		{
			return View();
		}
		[HttpPost]
		public async Task<IActionResult> EditNickName(ApplicationUser model)
		{

			var user = await _userManager.GetUserAsync(User);

			user.NickName = model.NickName;

			await _userManager.UpdateAsync(user);

			return RedirectToAction(nameof(HomeController.Index), "Home");
		}

		public IActionResult AccessDenied()
		{
			return View();
		}


	}
	}


	
