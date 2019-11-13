using GamesSearchAsp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GamesSearchAsp.ViewModels
{
    public class GamesResultViewModel
    {
        public GameListApiResponse Games { get; set; }

        public int TotalPages { get; set; }

        public int CurrentPage { get; set; }

        public string Title { get; set; }
    }
}
