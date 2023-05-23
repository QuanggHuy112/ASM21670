using System;
using ASM2.Helpers;
using ASM2.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ASM2.Controllers
{	
    [Authorize]
    public class PostsController : Controller
    {
        private readonly ILogger<PostsController> _logger;

        public PostsController(ILogger<PostsController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            List<Post> posts = DataHelper.GetAllPosts();
            return View(posts);
        }

        [Authorize(Policy = "EmailID")]
        public IActionResult Details(string id)
        {
            Post post = DataHelper.GetAllPosts().Find(p => p.Id.Equals(id));
            return View(post);
        }
        
    }
}

