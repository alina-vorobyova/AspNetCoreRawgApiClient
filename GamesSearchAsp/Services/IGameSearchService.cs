using GamesSearchAsp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GamesSearchAsp.Services
{
    public interface IGameSearchService
    {
        public Task<GameListApiResponse> SearchByTitleAsync(string title);
        public Task<GameDetailsApiResponse> SearchByIdAsync(int id);

        public Task<SimilarGamesApiResponse> SearchSimilarGamesAsync(int id);

        public Task<StoresListApiResponse> SearchStoresListAsync(int id);

        public Task<StoreInfo> SearchStoreByIdAsync(int id);
    }
}
