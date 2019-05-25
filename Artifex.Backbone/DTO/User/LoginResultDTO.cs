using ArtifexPay.Backbone.Domain;
using ArtifexPay.Backbone.Enums;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtifexPay.Backbone.DTO.User
{
    public class LoginResultDTO
    {
        public LoginResult LoginResult { get; set; }
        [JsonIgnore]
        public ArtifexUser ArtifexUser { get; set; }

        public UserProfileDTO User { get; set; }
        public void CreateProfile()
        {
            if (ArtifexUser != null)
            {
                User = new UserProfileDTO()
                {
                    Email = ArtifexUser.Username,
                    FullName = ArtifexUser.Name + " " + ArtifexUser.Surname,
                    Id = ArtifexUser.Id,
                };
            }
        }
    }
}
