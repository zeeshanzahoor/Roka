using ArtifexPay.Backbone.Data.Entity;

namespace ArtifexPay.Backbone.Domain.Auth
{
    public class AuthUserRoles : BaseEntity, IEntity
    {
        public int UserId { get; set; }
        public int RoleId { get; set; }
    }
}
