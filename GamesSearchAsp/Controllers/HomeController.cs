using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using GamesSearchAsp.Models;
using GamesSearchAsp.Services;
using GamesSearchAsp.ViewModels;

namespace GamesSearchAsp.Controllers
{
    public class HomeController : Controller
    {
        private readonly IGameSearchService gamesSearchService;
        private readonly IReviewService reviewService;

        public HomeController(IGameSearchService gamesSearchService, IReviewService reviewService)
        {
            this.gamesSearchService = gamesSearchService;
            this.reviewService = reviewService;
        }


        public async Task<IActionResult> Search(string title, int page = 1)
        {
            var result = await gamesSearchService.SearchByTitleAsync(title, page);
            var model = new SearchViewModel
            {
                Games = result.results,
                Title = title,
                TotalResults = result.count,
                TotalPages = (int)Math.Ceiling(result.count / 10.0),
                CurrentPage = page
            };
            return View(model);
        }

        public async Task<IActionResult> SearchResult(string title, int page = 1)
        {
            var result = await gamesSearchService.SearchByTitleAsync(title, page);
            return PartialView("_GameListPartial", result.results);
        }

        public async Task<IActionResult> GameDetails(int id)
        {
            var result = await gamesSearchService.SearchByIdAsync(id);
            var similarGames = await gamesSearchService.SearchSimilarGamesAsync(id);
            var storesList = await gamesSearchService.SearchStoresListAsync(id);
            var gameReview = await reviewService.GetReviewsAsync(id);
            Review review = new Review();
            var model = new GameDetailsViewModel
            {
                Game = result,
                SimilarGames = similarGames.results,
                StoresList = storesList.results,
                Reviews = gameReview,
                Review = review
            };
            //var allStoresList = await gamesSearchService.SearchAllStoresListAsync();
            //ViewBag.SimilarGames = similarGames.results;
            //ViewBag.Stores = storesList.results;
            //ViewBag.AllStoresList = allStoresList.results;
            return View(model);
        }


        [HttpPost]
        public async Task<IActionResult> PostReview(Review review)
        {
            await reviewService.AddReviewAsycn(review);
            return RedirectToAction("GameDetails", new { id = review.GameId });
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
