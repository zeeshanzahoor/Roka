using FluentValidation;
using FluentValidation.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArtifexPay.Web.Model.User
{
    [Validator(typeof(UserLoginModelValidator))]
    public class UserLoginModel
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }

    // bkz https://fluentvalidation.net/start
    public class UserLoginModelValidator : AbstractValidator<UserLoginModel>
    {
        public UserLoginModelValidator()
        {
            RuleFor(m => m.UserName)
                .NotEmpty();
            RuleFor(m => m.Password).NotEmpty();
        }
    }
}
