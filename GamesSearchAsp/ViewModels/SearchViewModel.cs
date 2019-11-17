using GamesSearchAsp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GamesSearchAsp.ViewModels
{
    public class SearchViewModel
    {
        public IEnumerable<Game> Games { get; set; }
        public string Title { get; set; }
        public int TotalResults { get; set; }
        public int TotalPages { get; set; }
        public int CurrentPage { get; set; }

    }
}
