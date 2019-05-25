using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ArtifexPay.Backbone.DTO;
using ArtifexPay.Backbone.Services;
using ArtifexPay.Web.Security;

namespace ArtifexPay.Web.Controllers
{
    public class TestController : Controller
    {
        private readonly IUserService _userService;
        public TestController(IUserService UserService)
        {
            _userService = UserService;
        }
        public IActionResult Filter(UserListDTOSpec Spec)
        {
            return null;
        }
    }
}