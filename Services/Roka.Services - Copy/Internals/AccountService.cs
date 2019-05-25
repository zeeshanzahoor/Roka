using ArtifexPay.Backbone.Data.Repository;
using ArtifexPay.Backbone.Domain;
using ArtifexPay.Backbone.DTO.User;
using ArtifexPay.Backbone.Security;
using ArtifexPay.Backbone.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtifexPay.Services.Internals
{
    internal class AccountService : IAccountService
    {
        protected readonly IRepository<ArtifexUser> _userRepository;
        protected readonly ITokenGenerator _tokenGenerator;


        public AccountService(IRepository<ArtifexUser> UserRepository, ITokenGenerator TokenGenerator)
        {
        _tokenGenerator = TokenGenerator;
            _userRepository = UserRepository;
        }
        public LoginResultDTO AuthenticateUser(string UserName, string Password)
        {
            //TODO: Authenticate from database
            var LoginResult = new LoginResultDTO()
            {
                LoginResult = Backbone.Enums.LoginResult.Success,
                ArtifexUser = new ArtifexUser() { Id = 1, Username = "zeeshan.zahoor" },
            };

            if (LoginResult.LoginResult == Backbone.Enums.LoginResult.Success)
            {
                String Token = _tokenGenerator.GenerateToken(LoginResult.ArtifexUser);
                LoginResult.CreateProfile();
                LoginResult.User.Token = Token;
                return LoginResult;
            }
            return null;
        }
    }
}
