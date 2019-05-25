using Microsoft.AspNet.Identity;
using ArtifexPay.Backbone.Audit.Types;
using ArtifexPay.Backbone.Data.Entity;
using ArtifexPay.Backbone.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtifexPay.Backbone.Domain
{
    public class ArtifexUser : BaseEntity, IEntity
    {
        public int ParentId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string PhoneNumber { get; set; }
        public int WrongPasswordCount { get; set; }
        public DateTime ActiveFrom { get; set; }
        public DateTime? ActiveTo { get; set; }
        public string Status { get; set; }
        public UserAccountStatus RokaUserAccountStatus { get; set; }
    }
}
