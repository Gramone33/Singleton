using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Singleton.Models;

namespace Singleton.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private CommentsArray commentsArray = CommentsArray.getSingleton();
        private IdUnique idUnique = IdUnique.getSingleton();
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        public IActionResult Index()
        {
            //commentsArray.AddComment("comment1");
            //commentsArray.AddComment("comment2");
            //commentsArray.AddComment("comment3");
            ViewData["commentArray"] = "";
            ViewData["id"] = idUnique.getNewId();
            foreach (var comment in commentsArray.Comments)
            {
                if (ViewData["commentArray"] == "")
                {
                    ViewData["commentArray"] += $"{comment}";
                }
                else
                {
                    ViewData["commentArray"] += $", {comment}";
                }
            }
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