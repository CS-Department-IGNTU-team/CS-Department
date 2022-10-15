using CSDepartment.Api.Services;
using CSDepartment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSDepartment.Api.Repositories
{
    public class PostRepository : IPostRepository
    {
        public Task<Post> AddPost()
        {
            throw new NotImplementedException();
        }

        public void DeletePost(string PostId)
        {
            throw new NotImplementedException();
        }

        public Task<Post> GetPost()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Post>> GetPosts()
        {
            throw new NotImplementedException();
        }

        public Task<Post> UpdatePost()
        {
            throw new NotImplementedException();
        }
    }
}
