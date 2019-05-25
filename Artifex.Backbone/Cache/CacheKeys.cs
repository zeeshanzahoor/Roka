using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtifexPay.Backbone.Cache
{
    public class CacheKeys
    {
        public static class ArtifexUser
        {
            public static string UserEntity { get { return UserEntity.GetType().FullName; } }
        }
    }
}
