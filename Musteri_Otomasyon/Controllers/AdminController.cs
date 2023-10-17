using DataAccess.Context;
using Entity;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace Musteri_Otomasyon.Controllers
{
    public class AdminController : Controller
    {
        [AllowAnonymous]
        public IActionResult Login()
        {
            return View();
        }
        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> Login(Admin admin)
        {
           context_musteri context = new context_musteri();
            Admin _admin = context.Admins.FirstOrDefault(x => x.Kullanici_Adi == admin.Kullanici_Adi
              && x.Sifre == admin.Sifre);
            if (_admin != null) 
            {
                var claims = new List<Claim>
                {
                      new Claim(ClaimTypes.Name,_admin.Kullanici_Adi)
                };
                var useridentity = new ClaimsIdentity(claims,"a");
                ClaimsPrincipal principal = new ClaimsPrincipal(useridentity);
                await HttpContext.SignInAsync(principal);
                return RedirectToAction("List","Musteri");

            }
            else
            {
                return View();
            }
        }
        [HttpGet]
        public async Task<IActionResult> LogOut()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Login");
        }
     

    }


}
