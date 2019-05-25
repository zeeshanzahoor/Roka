using ArtifexPay.Backbone.Audit;
using ArtifexPay.Backbone.Audit.Types;
using ArtifexPay.Backbone.Cache;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roka.Core.Audit.Internals
{
    internal class NullAuditLogger : IAuditLogger
    {
        private readonly ICacheStorage _cacheStorage;
        public NullAuditLogger(ICacheStorage CacheStorage)
        {
            _cacheStorage = CacheStorage;
        }
        public void LogDelete(IAuditDelete ExpiredEntity)
        {
        }

        public void LogInsert(IAuditInsert NewEntity)
        {
        }

        public void LogUpdate(IAuditUpdate OldEntity, IAuditUpdate NewEntity = null)
        {
        }
    }
}
