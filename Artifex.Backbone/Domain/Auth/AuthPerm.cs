using ArtifexPay.Backbone.Data.Entity;

namespace ArtifexPay.Backbone.Domain
{
    public class AuthPerm : BaseEntity, IEntity
    {
        public int AuthGroupId { get; set; }
        public string Identifier { get; set; }
        public string Name { get; set; }
    }
}
