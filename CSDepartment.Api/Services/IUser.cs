using CSDepartment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSDepartment.Api.Services
{
    interface IUser
    {
        Task<IEnumerable<User>> GetUsers();
        Task<User> GetUser();
        Task<User> AddUser();
        Task<User> UpdateUser();
        void DeleteUser(string Username);
    }
}
