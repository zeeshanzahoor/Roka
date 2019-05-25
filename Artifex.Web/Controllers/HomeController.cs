using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ArtifexPay.Backbone.Services;
using ArtifexPay.Backbone.Domain;
using System.Collections.Generic;
using ArtifexPay.Backbone.Security;
using System.Reflection;
using System.Linq;
using System.ComponentModel;
using System;

namespace ArtifexPay.Web.Controllers
{
    public class HomeController : Controller
    {
        private IUserService _userService;
        public HomeController(IUserService UserService)
        {
            _userService = UserService;
        }
        public IActionResult Index()
        {

            //var u =_userService.GetUserById(1);
            return View();
        }

        public IActionResult Error()
        {
            ViewData["RequestId"] = Activity.Current?.Id ?? HttpContext.TraceIdentifier;
            return View();
        }
    }
}
