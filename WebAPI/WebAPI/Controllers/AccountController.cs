using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    public class AccountController : WebApiControllerBase
    {
        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> LoginAsync(){
            //---------------------------------------------------------------------
            //-------------------------ログイン成功--------------------------------
            //---------------------------------------------------------------------
            var claims = new List<Claim> {
                    new Claim("UserId","test01"),
                    new Claim(ClaimTypes.Email, "yakushin-@gmail.com"),
                    new Claim(ClaimTypes.Role, "admin")
                };

            //ユーザー情報をクッキースキームとして登録
            var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

            //ポリシー記述
            var authProperties = new AuthenticationProperties
            {

            };

            //ログイン
            await HttpContext.SignInAsync(
                CookieAuthenticationDefaults.AuthenticationScheme,
                new ClaimsPrincipal(claimsIdentity),
                authProperties
            );

            return NoContent();
        }
    }
}
