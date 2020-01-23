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
                FooterViewModel = GetFooterViewModel(),
                Page = Context.BlogPageModels.FirstOrDefault(),
            };
            home.HeaderViewModel.CurrentPage = Menu.Blog;

            return View(home);
        }
    }
}