using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using ArtifexPay.Backbone.DTO.User;
using ArtifexPay.Backbone.Enums;
using ArtifexPay.Backbone.Security;
using ArtifexPay.Backbone.Services;
using ArtifexPay.Web.Model.Base;
using ArtifexPay.Web.Model.User;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace ArtifexPay.Web.Controllers
{
    public class AuthenticateController : Controller
    {
        protected readonly IAccountService _accountService;
        public AuthenticateController(IAccountService AccountService, IUserContext UserContext)
        {
            _accountService = AccountService;
        }
        public async Task<IActionResult> Login([FromBody]UserLoginModel model)
        {
            if (ModelState.IsValid)
            {
                Task<LoginResultDTO> LoginResult = Task.Run(() => _accountService.AuthenticateUser(model.UserName, model.Password));

                await Task.WhenAll(LoginResult);
                return Result.Create(true, LoginResult.Result);
            }
            return Result.Create(false);
        }
    }
}