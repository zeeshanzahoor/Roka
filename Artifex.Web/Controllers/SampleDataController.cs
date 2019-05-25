using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ArtifexPay.Backbone.Domain;
using ArtifexPay.Backbone.DTO;
using ArtifexPay.Backbone.Pagination;
using ArtifexPay.Backbone.Services;
using ArtifexPay.Web.Security;
using Microsoft.AspNetCore.Authorization;

namespace ArtifexPay.Web.Controllers
{
    public class SampleDataController : Controller
    {
        protected readonly IUserService _userService;
        public SampleDataController(IUserService UserService)
        {
            _userService = UserService;
        }

        [HttpPost]
        public IActionResult FillUserGrid([FromBody]PaginationArgs args, UserListDTOSpec spec)
        {
            var result = _userService.Filter(args, spec);

            return Json(result);
        }

    }
}
