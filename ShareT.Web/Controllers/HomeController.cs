using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ShareT.Common;

namespace ShareT.Web.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Index()
        {
            return View();
        }

        public ViewResult About()
        {
            return View();
        }

        [AllowAnonymous]
        public IActionResult ValidateCode()
        {
            ValidateCode _vierificationCodeServices = new ValidateCode();
            string code = "";
            System.IO.MemoryStream ms = _vierificationCodeServices.Create(out code);
            //CookieUtility.AppendCookie(Constant.WEBSITE_VERIFICATION_CODE, code);//ContextHelper.Encrypt(code)
            return File(ms.ToArray(), @"image/png");
        }

        [Route("Welcome")]
        public ViewResult Welcome()
        {
            return View();
        }
        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";
            //return File();

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View();
        }
    }
}
