using ArtifexPay.Backbone.Domain;
using ArtifexPay.Backbone.Security;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ArtifexPay.Core.Security.Internals
{
    internal class AuthSynchronizer
    {
        public static void Synchronize()
        {
            IList<AuthGroup> AuthGroups = typeof(Permissions).GetNestedTypes(BindingFlags.Public).Select(Group => new AuthGroup()
            {
                Name = Group.GetCustomAttribute<DescriptionAttribute>()?.Description ?? Group.Name,
                UniqueIdentifier = Group.FullName,
                AuthPerm = Group.GetProperties().Select(Property => new AuthPerm()
                {
                    Name = Property.GetCustomAttribute<DescriptionAttribute>()?.Description ?? Property.Name,
                    Identifier = String.Format("{0}+{1}", Property.DeclaringType.FullName, Property.Name),
                }).ToList(),
            }).ToList();


            // Save to database

            //context.Database.ExecuteSqlCommand("delete from [AuthPerm];DBCC CHECKIDENT ('[AuthPerm]', RESEED, 0);");
            //context.SaveChanges();
            //context.Database.ExecuteSqlCommand("delete from [AuthGroup];DBCC CHECKIDENT ('[AuthGroup]', RESEED, 0);");
            //context.SaveChanges();

            //foreach (AuthGroup AuthGroup in AuthGroups)
            //{
            //    context.AuthGroup.Add(AuthGroup);
            //}
            //context.SaveChanges();
        }
    }
}
