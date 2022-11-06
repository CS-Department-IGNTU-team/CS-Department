using CSDepartment.Api.Services;
using CSDepartment.Models;
using Microsoft.EntityFrameworkCore;
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

        public async Task<User> AddUser(User user)
        {
            var result = await appDBContext.Users.AddAsync(user);
            await appDBContext.SaveChangesAsync();
            return result.Entity;
        }

        public async void DeleteUser(string Username)
        {
            var result = await appDBContext.Users.FirstOrDefaultAsync(e => e.Username == Username);
            if (result != null)
            {
                appDBContext.Users.Remove(result);
                await appDBContext.SaveChangesAsync();
            }
        }

        public async Task<User> GetUser(string Username)
        {
            return await appDBContext.Users.FirstOrDefaultAsync(e => e.Username == Username);
        }

        public async Task<IEnumerable<User>> GetUsers()
        {
            return await appDBContext.Users.ToListAsync();
        }

        public async Task<User> UpdateUser(User user)
        {
            var result = await appDBContext.Users.FirstOrDefaultAsync(e => e.Username == user.Username);

            if (result != null)
            {
                result.Name = user.Username;
                result.Role = user.Role;
                result.Password = user.Password;
                result.Email = user.Password;
            }

            await appDBContext.SaveChangesAsync();

            return result;
        }
    }
}
