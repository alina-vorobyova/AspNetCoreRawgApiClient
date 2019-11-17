using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GamesSearchAsp.ViewModels
{
    public class PaginationsViewModel
    {
        public int TotalPages { get; set; }
        public int CurrentPage { get; set; }
        public string Controller { get; set; }
        public string Action { get; set; }
        public Dictionary<string, string> RouteParams { get; set; }
    }
}
