using ArtifexPay.Backbone.Data.Entity;

namespace ArtifexPay.Backbone.Domain
{
    public class AuthRolePerms : BaseEntity, IEntity
    {
        public int RoleId { get; set; }
        public string AuthPermIdentifier { get; set; }
    }
}
