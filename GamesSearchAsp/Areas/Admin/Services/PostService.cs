using GamesSearchAsp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GamesSearchAsp.Areas.Admin.Services
{
    public class PostService : IPostService
    {
        private readonly GameAppDbContext context;

        public PostService(GameAppDbContext context)
        {
            this.context = context;
        }

        public async Task AddPostAsync(Post post)
        {
            await context.AddAsync(post);
            await context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Post>> GetAllPosts()
        {
            return await context.Posts.ToListAsync();
        }

      
    }
}
