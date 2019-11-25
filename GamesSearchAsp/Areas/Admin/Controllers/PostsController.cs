using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GamesSearchAsp.Areas.Admin.Services;
using GamesSearchAsp.Helpers;
using GamesSearchAsp.Models;
using Microsoft.AspNetCore.Http;
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
        public async Task<IActionResult> Create(Post post, IFormFile uploadImg)
        {
            if (uploadImg != null)
            {
                var path = await FileUploadHelper.UploadFile(uploadImg);
                post.ImageUrl = path;
                if (ModelState.IsValid)
                {
                    post.Date = DateTime.Now;
                    await postService.AddPostAsync(post);
                    return RedirectToAction("Index");
                }
            }
            else
            {
                if (ModelState.IsValid)
                {
                    post.Date = DateTime.Now;
                    await postService.AddPostAsync(post);
                    return RedirectToAction("Index");
                }
            }
          

           
            return View();
        }
    }
}