using ArtifexPay.Backbone.DTO;
using ArtifexPay.Backbone.DTO.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtifexPay.Backbone.Services
{
    public interface IAccountService
    {
        LoginResultDTO AuthenticateUser(string UserName, string Password);
    }
}
