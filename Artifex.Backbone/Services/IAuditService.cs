using ArtifexPay.Backbone.Audit.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtifexPay.Backbone.Services
{
    public interface IAuditService
    {
        void HandleAuditUpdate(IAuditUpdate OldEntity, IAuditUpdate NewEntity = null);
        void HandleAuditInset(IAuditInsert NewEntity);
        void HandleAuditDelete(IAuditDelete ExpiredEntity);
    }
}
