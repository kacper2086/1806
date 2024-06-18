using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using YourNamespace.Models;
using YourNamespace.ViewModels;


public class AccountController : Controller
{
    private readonly SignInManager<ApplicationUser> _signInManager;

    public AccountController(SignInManager<ApplicationUser> signInManager)
    {
        _signInManager = signInManager;
    }

    [HttpGet]
    public IActionResult Login()
    {
        return View();
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Login(LoginViewModel model, string returnUrl = null)
    {
        if (ModelState.IsValid)
        {
            var result = await _signInManager.PasswordSignInAsync(model.Email, model.Password, model.RememberMe, lockoutOnFailure: false);
            if (result.Succeeded)
            {
                return RedirectToLocal(returnUrl);
            }
            ModelState.AddModelError(string.Empty, "Invalid login attempt.");
        }
        return View(model);
    }

    private IActionResult RedirectToLocal(string returnUrl)
    {
        if (Url.IsLocalUrl(returnUrl))
        {
            return Redirect(returnUrl);
        }

        var user = HttpContext.User;
        if (User.IsInRole("Magazynier"))
        {
            return RedirectToAction("Index", "Magazynier"); // Przekierowanie do panelu Magazyniera
        }
        else if (User.IsInRole("Serwis"))
        {
            return RedirectToAction("Index", "Serwis"); // Przekierowanie do panelu Serwisanta
        }
        else if (User.IsInRole("Klient"))
        {
            return RedirectToAction("Index", "Klient"); // Przekierowanie do panelu Klienta
        }
        else
        {
            return RedirectToAction("Index", "Home"); // Przekierowanie na stronę główną
        }
    }
}
