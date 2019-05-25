using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ArtifexPay.Backbone.Cache
{
    public interface ICacheStorage
    {
        void Remove(string key);
        void Store(string key, object data, int ExpirationInDays = 365);
        T Retrieve<T>(string key);
        void ResetCacheItem(string key);
        void Reset();

        void Store<T>(T data, Expression<Func<T, object>> Key);
    }
}
