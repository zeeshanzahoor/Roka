using ArtifexPay.Backbone.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtifexPay.Core.Security.Internals
{
    internal class TennantContext : ITennantContext
    {
        public int TenantId { get { return 1; } }
        public string ConnectionString { get { return ""; } }
        public string CompanyName { get { return ""; } }
    }
}
