using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtifexPay.Backbone.Security
{
    public interface ITennantContext
    {
        int TenantId { get; }
        string ConnectionString { get; }
        string CompanyName { get; }
    }
}
