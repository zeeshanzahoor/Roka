using ArtifexPay.Backbone.Data.Entity;

namespace ArtifexPay.Backbone.Domain
{
    public class AuthUserPermRule : BaseEntity, IEntity
    {
        public int UserId { get; set; }
        public string AuthPermIdentifier { get; set; }
        public bool IsAllowed { get; set; }
    }
}
