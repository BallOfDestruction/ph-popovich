using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PhPopovich.Models;
using PhPopovich.ViewModels.Home;

namespace PhPopovich.Controllers
{
    public class HomeController : CommonController
    {
        public HomeController(Context context)
        {
            Context = context;
        }

        public IActionResult Index()
        {
            var home = new HomePageViewModel()
            {
                HeaderViewModel = GetHeader(),
                Page = Context.MainPageModels.Include(w => w.ImageModel).FirstOrDefault(),
            };

            var c = Context.MainPageModels.ToList();
            var b = Context.MainPageModels.Include(w => w.ImageModel).ToList();
            var cc = Context.MainPageModels.FirstOrDefault();

            home.HeaderViewModel.Title = home.HeaderViewModel.CompanyName;
            home.HeaderViewModel.CurrentPage = Menu.Main;

            return View(home);
        }
    }
}
