using System.Collections.Generic;
using System.Threading.Tasks;
using DatingApp.Api.Helpers;
using DatingApp.Api.models;

namespace DatingApp.Api.Data
{
    public interface IDatingRepository
    {
        void Add<T>(T entity) where T: class;
        void Delete<T>(T entity) where T: class;
        Task<bool> SaveAll();
        Task<PagedList<User>> GetUsers(UserParams userParams);
        Task<User> GetUser(int id);
        Task<Photo> GetPhoto(int id);
    }
}