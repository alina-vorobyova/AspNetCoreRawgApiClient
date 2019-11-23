using GamesSearchAsp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GamesSearchAsp.Services
{
    public interface IReviewService
    {
        Task<IEnumerable<Review>> GetReviewsAsync(int gameId);

        Task AddReviewAsycn(Review review);
    }
}
