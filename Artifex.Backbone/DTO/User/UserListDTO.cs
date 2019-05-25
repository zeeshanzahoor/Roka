using ArtifexPay.Backbone.Specification;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtifexPay.Backbone.DTO
{
    public class UserListDTO
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
    }

    public class UserListDTOSpec : BaseSpec<UserListDTO>
    {
        public override IQueryable<UserListDTO> ApplySpec(IQueryable<UserListDTO> c)
        {
            c = c.Where(m => m.Id > 0);
            return c;
        }
    }
}
