
using System;
using System.Linq.Expressions;
using ArtifexPay.Backbone.Cache;

namespace ArtifexPay.Core.Cache.Internals
{
    internal class RedisCacheStorage : ICacheStorage
    {
        public void Remove(string key)
        {
            throw new NotImplementedException();
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }

        public void ResetCacheItem(string key)
        {
            throw new NotImplementedException();
        }

        public T Retrieve<T>(string key)
        {
            throw new NotImplementedException();
        }

        public void Store(string key, object data, int ExpirationInDays = 365)
        {
            throw new NotImplementedException();
        }

        public void Store<T>(T data, Expression<Func<T, object>> Key)
        {
            throw new NotImplementedException();
        }
    }
}
