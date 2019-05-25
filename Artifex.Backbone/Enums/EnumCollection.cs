using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtifexPay.Backbone.Enums
{
    public enum LoginResult
    {
        Success = 1,
        WrongPassword = 2,
        WrongUserName = 3,
        AccountBlocked = 4,
        AccountRequiresActivation = 5
    }
    public enum UserAccountStatus
    {
        Active = 1,
        WaitingForMailActivation = 2,
        WaitingForOtpConfirmation = 3,
    }
}
