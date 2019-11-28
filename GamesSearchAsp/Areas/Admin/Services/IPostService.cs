using GamesSearchAsp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GamesSearchAsp.Areas.Admin.Services
{
    public interface IPostService
    {
        public Task AddPostAsync(Post post);

        public Task<IEnumerable<Post>> GetAllPosts();

        public Task UpdatePostAsync(Post post);

        public Task RemovePostAsync(int id);
    }
}
