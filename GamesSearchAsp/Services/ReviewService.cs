using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GamesSearchAsp.Models;
using Microsoft.EntityFrameworkCore;

namespace GamesSearchAsp.Services
{
    public class ReviewService : IReviewService
    {
        private readonly GameAppDbContext context;

        public ReviewService(GameAppDbContext context)
        {
            this.context = context;
        }

        public async Task AddReviewAsycn(Review review)
        {
             context.Reviews.Add(review);
            await context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Review>> GetReviewsAsync(int gameId)
        {
            return await context.Reviews.Where(x => x.GameId == gameId).ToListAsync();
        }
    }
}
