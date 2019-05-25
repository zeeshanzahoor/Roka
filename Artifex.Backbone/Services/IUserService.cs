using ArtifexPay.Backbone.Domain;
using ArtifexPay.Backbone.DTO;
using ArtifexPay.Backbone.Pagination;
using System.Collections.Generic;

namespace ArtifexPay.Backbone.Services
{
    public interface IUserService
    {
        IList<UserListDTO> GetUsersList();
        UserListDTO GetUserDTOById(int Id);
        ArtifexUser GetUserById(int Id);
        PagedResult<UserListDTO> Filter(PaginationArgs args, UserListDTOSpec spec);
    }
}
