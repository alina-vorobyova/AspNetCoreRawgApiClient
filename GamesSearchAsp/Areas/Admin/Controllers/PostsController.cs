using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GamesSearchAsp.Areas.Admin.Services;
using GamesSearchAsp.Models;
using Microsoft.AspNetCore.Mvc;

namespace GamesSearchAsp.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class PostsController : Controller
    {
        private readonly IPostService postService;

        public PostsController(IPostService postService)
        {
            this.postService = postService;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var posts = await postService.GetAllPosts();
            return View(posts);
        }


        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Post post)
        {
            post.Date = DateTime.Now;
            await postService.AddPostAsync(post);
            return RedirectToAction("Index");
        }
    }
}