using System.Linq;
using Microsoft.AspNetCore.Mvc;
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
                Page = Context.BlogPageModels.FirstOrDefault(),
            };
            home.HeaderViewModel.Title = home.HeaderViewModel.CompanyName;
            home.HeaderViewModel.CurrentPage = Menu.Blog;

            return View(home);
        }
    }
}