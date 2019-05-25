using ArtifexPay.Backbone.Audit.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtifexPay.Backbone.Audit
{
    public interface IAuditLogger
    {
        void LogUpdate(IAuditUpdate OldEntity, IAuditUpdate NewEntity = null);
        void LogInsert(IAuditInsert NewEntity);
        void LogDelete(IAuditDelete ExpiredEntity);
    }
}
