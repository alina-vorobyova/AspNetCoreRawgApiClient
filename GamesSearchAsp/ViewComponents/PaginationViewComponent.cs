using GamesSearchAsp.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GamesSearchAsp.ViewComponents
{
    public class PaginationViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(
            int totalPages,
            int currentPage,
            string controller,
            string action,
            Dictionary<string, string> routeParams
            )
        {
            var model = new PaginationsViewModel
            {
                TotalPages = totalPages,
                CurrentPage = currentPage,
                Controller = controller,
                Action = action,
                RouteParams = routeParams
            };

            return View(model);
        }
    }
}
