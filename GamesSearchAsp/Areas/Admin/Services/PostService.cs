using GamesSearchAsp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
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
            await context.Posts.AddAsync(post);
            await context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Post>> GetAllPosts()
        {
            return await context.Posts.ToListAsync();
        }

        public async Task RemovePostAsync(int id)
        {
            var choosedPost = context.Posts.Find(id);
            System.IO.File.Delete(@$"wwwroot/{choosedPost.ImageUrl}");
            if (choosedPost != null)
            {
                context.Posts.Remove(choosedPost);
                await context.SaveChangesAsync();
            }
            else throw new Exception("Post not found");
        }

        public async Task UpdatePostAsync(Post post)
        {
            context.Posts.Update(post);
             await context.SaveChangesAsync();
        }
    }
}
