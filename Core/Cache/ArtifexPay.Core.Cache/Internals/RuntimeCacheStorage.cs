﻿using ArtifexPay.Backbone.Cache;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ArtifexPay.Core.Cache.Internals
{
    internal class RuntimeCacheStorage : ICacheStorage
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
            //TODO: this concept is to be improved
            Store(typeof(T).FullName + "____" + Key.Compile().Invoke(data).ToString(), data);
        }
    }
}
