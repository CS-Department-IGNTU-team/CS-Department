using CSDepartment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSDepartment.Api.Services
{
    public interface IUserRepository
    {
        Task<IEnumerable<User>> GetUsers();
        Task<User> GetUser(string Username);
        Task<User> AddUser(User user);
        Task<User> UpdateUser(User user);
        void DeleteUser(string Username);
    }
}
