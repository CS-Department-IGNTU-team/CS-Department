using CSDepartment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSDepartment.Api.Services
{
    public interface IPostRepository
    {
        Task<IEnumerable<Post>> GetPosts();
        Task<Post> GetPost();
        Task<Post> AddPost();
        Task<Post> UpdatePost();
        void DeletePost(string PostId);
    }
}
