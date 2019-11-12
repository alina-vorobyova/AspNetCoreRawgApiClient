using GamesSearchAsp.Models;
using GamesSearchAsp.Services;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading.Tasks;

namespace GamesSearchAsp.TagHelpers
{
    [HtmlTargetElement("a", Attributes = "store")]
    public class StoreLinkTagHelper : TagHelper
    {
        private readonly IGameSearchService gameSearchService;

        public StoreLinkTagHelper(IGameSearchService gameSearchService)
        {
            this.gameSearchService = gameSearchService;
        }
        public StoresResult store { get; set; }

        public async override Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "a";
            output.AddClass("btn", HtmlEncoder.Default);
            output.AddClass("btn-primary", HtmlEncoder.Default);
            //output.Content.Append(store.store_id.ToString());
            var storeObj = await gameSearchService.SearchStoreByIdAsync(store.store_id);
            output.Content.Append(storeObj.name);
        }
    }
}
