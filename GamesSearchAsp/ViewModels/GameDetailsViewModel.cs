using GamesSearchAsp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GamesSearchAsp.ViewModels
{
    public class GameDetailsViewModel
    {
        public GameDetailsApiResponse Game { get; set; }
        public IEnumerable<Result> SimilarGames { get; set; }
        public IEnumerable<StoresResult> StoresList { get; set; }
        public IEnumerable<Review> Reviews { get; set; }
        public Review Review { get; set; }
    }
}
