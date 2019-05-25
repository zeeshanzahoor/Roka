using ArtifexPay.Backbone.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtifexPay.Backbone.Security
{
    public interface ITokenGenerator
    {
        string GenerateToken(ArtifexUser User);
    }
}
