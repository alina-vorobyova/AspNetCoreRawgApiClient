using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using GamesSearchAsp.Models;
using GamesSearchAsp.Services;

namespace GamesSearchAsp.Controllers
{
    public class HomeController : Controller
    {
        private readonly IGameSearchService gamesSearchService;

        public HomeController(IGameSearchService gamesSearchService)
        {
            this.gamesSearchService = gamesSearchService;
        }


        public async Task<IActionResult> Search(string title)
        {
            var result = await gamesSearchService.SearchByTitleAsync(title);
            return View(result);
        }

        public async Task<IActionResult> GameDetails(int id)
        {
            var result = await gamesSearchService.SearchByIdAsync(id);
            ViewBag.Result = result;
            return View(result);
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
