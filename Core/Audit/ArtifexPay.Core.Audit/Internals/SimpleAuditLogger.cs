using ArtifexPay.Backbone.Audit;
using ArtifexPay.Backbone.Audit.Types;
using ArtifexPay.Backbone.Security;
using ArtifexPay.Backbone.Services;
using System;

namespace Roka.Core.Audit.Internals
{
    internal class SimpleAuditLogger : IAuditLogger
    {
        private readonly IUserContext UserContext;
        private readonly IAuditService _auditService;
        public SimpleAuditLogger(IUserContext UserContext, IAuditService AuditService)
        {
            this.UserContext = UserContext;
            _auditService = AuditService;
        }
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
