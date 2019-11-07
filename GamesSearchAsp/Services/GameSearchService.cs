using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GamesSearchAsp.Models;

namespace GamesSearchAsp.Services
{
    public class GameSearchService : IGameSearchService
    {
        public GameSearchService() 
        {

        }

        public Task<GameListApiResponse> SearchByTitleAsync(string title)
        {
            throw new NotImplementedException();
        }
    }
}
