using ArtifexPay.Backbone.Data.Entity;
using System;

namespace ArtifexPay.Backbone.Domain
{
    public class AuthRole : BaseEntity, IEntity
    {
        public String Name { get; set; }
    }
}
