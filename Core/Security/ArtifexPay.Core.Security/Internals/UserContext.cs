using System;
using Microsoft.AspNetCore.Http;
using ArtifexPay.Backbone.Audit;
using ArtifexPay.Backbone.Domain;
using ArtifexPay.Backbone.Security;
using ArtifexPay.Backbone.Services;
using Microsoft.AspNet.Identity;
using ArtifexPay.Backbone.Cache;

namespace ArtifexPay.Core.Security.Internals
{
    internal class UserContext : IUserContext
    {
        public ArtifexUser CurrentUser { get; private set; }
        public HttpContext HttpContext { get; private set; }
        public UserContext(IHttpContextAccessor HttpContextAccessor, IUserService UserService, ICacheStorage CacheStorage)
        {
            HttpContext HttpContext = HttpContextAccessor.HttpContext;
            this.HttpContext = HttpContext;

            string UserId = HttpContext.User.Identity.GetUserId();
            if (!String.IsNullOrEmpty(UserId))
            {
                string CacheKey = CacheKeys.ArtifexUser.UserEntity + UserId;
                this.CurrentUser = CacheStorage.Retrieve<ArtifexUser>(CacheKey);
                if (this.CurrentUser == null)
                {
                    this.CurrentUser = UserService.GetUserById(Convert.ToInt32(UserId));
                    CacheStorage.Store(CacheKey, this.CurrentUser);
                }
                if (this.CurrentUser == null)
                {
                    throw new UnauthorizedAccessException();
                }
            }
        }

    }
}
