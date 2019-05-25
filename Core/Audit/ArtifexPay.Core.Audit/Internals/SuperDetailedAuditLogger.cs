using ArtifexPay.Backbone.Audit;
using ArtifexPay.Backbone.Audit.Types;
using System;

namespace Roka.Core.Audit.Internals
{
    internal class SuperDetailedAuditLogger : IAuditLogger
    {
        public void LogDelete(IAuditDelete ExpiredEntity)
        {
            throw new NotImplementedException();
        }

        public void LogInsert(IAuditInsert NewEntity)
        {
            throw new NotImplementedException();
        }

        public void LogUpdate(IAuditUpdate OldEntity, IAuditUpdate NewEntity = null)
        {
            throw new NotImplementedException();
        }
    }
}
