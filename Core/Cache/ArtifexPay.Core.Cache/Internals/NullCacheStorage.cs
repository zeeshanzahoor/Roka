
using ArtifexPay.Backbone.Cache;

namespace ArtifexPay.Core.Cache.Internals
{
    internal class NullCacheStorage //: ICacheStorage
    {
        public void Remove(string key)
        {
        }

        public void Reset()
        {
        }

        public void ResetCacheItem(string key)
        {
        }

        public T Retrieve<T>(string key)
        {
            return default(T);
        }

        public void Store(string key, object data, int ExpirationInDays = 365)
        {

        }
    }
}
