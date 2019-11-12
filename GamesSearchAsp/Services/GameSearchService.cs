using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using GamesSearchAsp.Models;
using GamesSearchAsp.Options;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;

namespace GamesSearchAsp.Services
{
    public class GameSearchService : IGameSearchService
    {
        private HttpClient httpClient;
        private readonly string url;
        private readonly GameApiOptions gameApiOptions;
        private readonly IMemoryCache memoryCache;

        public GameSearchService(IHttpClientFactory httpClientFactory, IOptions<GameApiOptions> options, IMemoryCache memoryCache)
        {
            gameApiOptions = options.Value;
            httpClient = httpClientFactory.CreateClient();
            url = gameApiOptions.Url;
            this.memoryCache = memoryCache;
        }

        public async Task<GameListApiResponse> SearchByTitleAsync(string title)
        {
            title = title.ToLower();
            GameListApiResponse result;
            if (!memoryCache.TryGetValue(title, out result))
            {
                var response = await httpClient.GetAsync($"{url}/games?search={title}");
                var json = await response.Content.ReadAsStringAsync();
                result = JsonConvert.DeserializeObject<GameListApiResponse>(json);

                memoryCache.Set(title, result);
            }
            return result;
        }

        public async Task<GameDetailsApiResponse> SearchByIdAsync(int id)
        {
            GameDetailsApiResponse result;
            if (!memoryCache.TryGetValue(id, out result))
            {
                var response = await httpClient.GetAsync($"{url}/games/{id}");
                var json = await response.Content.ReadAsStringAsync();
                result = JsonConvert.DeserializeObject<GameDetailsApiResponse>(json);

                if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
                    throw new Exception(result.detail);
                memoryCache.Set(id, result);
            }
            return result;
        }

        public async Task<SimilarGamesApiResponse> SearchSimilarGamesAsync(int id)
        {
            SimilarGamesApiResponse result;
            if (!memoryCache.TryGetValue(id, out result))
            {
                var response = await httpClient.GetAsync($"{url}/games/{id}/suggested");
                var json = await response.Content.ReadAsStringAsync();
                result = JsonConvert.DeserializeObject<SimilarGamesApiResponse>(json);

                if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
                    throw new Exception("Not found");
                memoryCache.Set(id, result);
            }
            return result;
        }

        public async Task<StoresListApiResponse> SearchStoresListAsync(int id)
        {
            StoresListApiResponse result;
            if (!memoryCache.TryGetValue(id, out result))
            {
                var response = await httpClient.GetAsync($"{url}/games/{id}/stores");
                var json = await response.Content.ReadAsStringAsync();
                result = JsonConvert.DeserializeObject<StoresListApiResponse>(json);

                if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
                    throw new Exception("Not found");
                memoryCache.Set(id, result);
            }
            return result;
        }

        public async Task<StoreInfo> SearchStoreByIdAsync(int id)
        {
            StoreInfo result;
            if (!memoryCache.TryGetValue("GameSearchAspStoresKey", out result))
            {
                var response = await httpClient.GetAsync($"{url}/stores/{id}");
                var json = await response.Content.ReadAsStringAsync();
                result = JsonConvert.DeserializeObject<StoreInfo>(json);

                if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
                    throw new Exception("Not found");
                memoryCache.Set("GameSearchAspStoresKey", result);
            }
            return result;
        }

       
    }
}
