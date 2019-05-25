using ArtifexPay.Backbone.Logging;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtifexPay.Web.Security
{
    public class PermissionsAuthorizationRequirement : IAuthorizationRequirement
    {
        public IEnumerable<Permission> RequiredPermissions { get; }

        public PermissionsAuthorizationRequirement(IEnumerable<Permission> requiredPermissions)
        {
            RequiredPermissions = requiredPermissions;
        }
    }
    public enum Permission
    {
        AddUser,
        DeleteUser
    }

    public class PermissionHandler : AuthorizationHandler<PermissionsAuthorizationRequirement>
    {

        public PermissionHandler()
        {

        }

        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, PermissionsAuthorizationRequirement requirement)
        {
            throw new NotImplementedException();
        }
    }

    public class RequiresPermissionAttribute : TypeFilterAttribute
    {
        public RequiresPermissionAttribute(params Permission[] permissions) : base(typeof(RequiresPermissionAttributeImpl))
        {
            Arguments = new[] { new PermissionsAuthorizationRequirement(permissions) };
        }
    }
    public class RequiresPermissionAttributeImpl : Attribute, IAsyncResourceFilter
    {
        private readonly PermissionsAuthorizationRequirement _requiredPermissions;

        public RequiresPermissionAttributeImpl(PermissionsAuthorizationRequirement requiredPermissions)
        {
            _requiredPermissions = requiredPermissions;
        }

        public async Task OnResourceExecutionAsync(ResourceExecutingContext context, ResourceExecutionDelegate next)
        {
            await next();
        }
    }
}
