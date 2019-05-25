using ArtifexPay.Backbone.Data.Entity;
using System.Collections.Generic;

namespace ArtifexPay.Backbone.Domain
{
    public class AuthGroup : BaseEntity, IEntity
    {
        public string Name { get; set; }
        public string UniqueIdentifier { get; set; }
        public virtual IList<AuthPerm> AuthPerm { get; set; } = new List<AuthPerm>();
        public override bool Equals(object obj)
        {
            if (obj == null || obj as AuthGroup == null)
                return false;

            var ObjectToCompare = obj as AuthGroup;
            if (ObjectToCompare.UniqueIdentifier == this.UniqueIdentifier)
            {
                return true;
            }
            return false;
        }
        public override int GetHashCode()
        {
            return this.UniqueIdentifier.GetHashCode();
        }
    }
}
