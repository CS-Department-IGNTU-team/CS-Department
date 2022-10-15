using CSDepartment.Api.Services;
using CSDepartment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSDepartment.Api.Repositories
{
    public class UserRepository : IUserRepository
    {
        // Constructor Dependency injection
        private readonly AppDBContext appDBContext;

        public UserRepository(AppDBContext appDBContext)
        {
            this.appDBContext = appDBContext;
        }

        public Task<User> AddUser()
        {
            throw new NotImplementedException();
        }

        public void DeleteUser(string Username)
        {
            throw new NotImplementedException();
        }

        public Task<User> GetUser()
        {
            throw new NotImplementedException();
        }

        public  Task<IEnumerable<User>> GetUsers()
        {
            return appDBContext.Users.ToList();
        }

        public Task<User> UpdateUser()
        {
            throw new NotImplementedException();
        }
    }
}
