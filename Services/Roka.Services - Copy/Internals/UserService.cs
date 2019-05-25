using System.Collections.Generic;
using System.Linq;
using ArtifexPay.Backbone.Data.Repository;
using ArtifexPay.Backbone.Domain;
using ArtifexPay.Backbone.DTO;
using ArtifexPay.Backbone.Pagination;
using ArtifexPay.Backbone.Services;

namespace ArtifexPay.Services.Internals
{
    internal class UserService : BaseService, IUserService
    {
        private readonly IRepository<ArtifexUser> _userRepository;
        public UserService(IRepository<ArtifexUser> UserRepository)
        {
            _userRepository = UserRepository;
        }

        public PagedResult<UserListDTO> Filter(PaginationArgs args, UserListDTOSpec spec)
        {
            var us = new List<UserListDTO>() {
                new UserListDTO() {Id = 1, Name = "Zeeshan", Surname = "Zahoor" },
                new UserListDTO() {Id = 2, Name = "Zeeshan", Surname = "Zahoor" },
                new UserListDTO() {Id = 3, Name = "Zeeshan", Surname = "Zahoor" },
                new UserListDTO() {Id = 4, Name = "Zeeshan", Surname = "Zahoor" },
                new UserListDTO() {Id = 5, Name = "Zeeshan", Surname = "Zahoor" },
                new UserListDTO() {Id = 6, Name = "Zeeshan", Surname = "Zahoor" },
                new UserListDTO() {Id = 7, Name = "Zeeshan", Surname = "Zahoor" },
                new UserListDTO() {Id = 8, Name = "Zeeshan", Surname = "Zahoor" },
                new UserListDTO() {Id = 9, Name = "Zeeshan", Surname = "Zahoor" },
                new UserListDTO() {Id = 10, Name = "Zeeshan", Surname = "Zahoor" },
                new UserListDTO() {Id = 11, Name = "Zeeshan", Surname = "Zahoor" },
            };

            //var q = _userRepository.All.Select(m => new UserListDTO()
            //{

            //});
            var u = spec.ApplySpec(us.AsQueryable());
            return this.ApplyPagination(us.AsQueryable(), args);
        }

        public ArtifexUser GetUserById(int Id)
        {
            return _userRepository.SelectById(1);
        }

        public UserListDTO GetUserDTOById(int Id)
        {
            var q = from user in _userRepository.All
                    where user.Id == Id
                    select new UserListDTO()
                    {
                        Id = user.Id,
                        FullName = user.Name + " " + user.Surname
                    };
            return q.FirstOrDefault();
        }

        public IList<UserListDTO> GetUsersList()
        {
            var q = from user in _userRepository.All
                    select new UserListDTO()
                    {
                        Id = user.Id,
                        FullName = user.Name + " " + user.Surname
                    };
            return q.ToList();
        }
    }
}
