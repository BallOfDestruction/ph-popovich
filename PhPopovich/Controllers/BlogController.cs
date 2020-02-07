using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.EntityFrameworkCore;
using PhPopovich.Models;
using PhPopovich.ViewModels.Blog;

namespace PhPopovich.Controllers
{
    public class BlogController : CommonController
    {
        public BlogController(Context context)
        {
            Context = context;
        }

        public IActionResult Index()
        {
            var home = new BlogPageViewModel()
            {
                HeaderViewModel = GetHeader(),
                FooterViewModel = GetFooterViewModel(),
                Page = Context.BlogPageModels.FirstOrDefault(),
                ArticleModels = Context.ArticleModels
                    .Include(w => w.ImageModel)
                    .ToList()
            };
            home.HeaderViewModel.CurrentPage = Menu.Blog;

            return View(home);
        }
        
        public IActionResult Get(Guid id)
        {
            var home = new ArticleViewModel()
            {
                HeaderViewModel = GetHeader(),
                FooterViewModel = GetFooterViewModel(),
                ArticleModel = Context.ArticleModels
                    .Include(w => w.ImageModel)
                    .FirstOrDefault(w => w.Id == id)
            };
            home.HeaderViewModel.CurrentPage = Menu.Blog;

            return View(home);
        }
    }
}