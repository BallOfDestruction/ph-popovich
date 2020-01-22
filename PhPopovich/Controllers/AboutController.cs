using System.Linq;
using Microsoft.AspNetCore.Mvc;
using PhPopovich.Models;
using PhPopovich.ViewModels.About;

namespace PhPopovich.Controllers
{
    public class AboutController : CommonController
    {
        public AboutController(Context context)
        {
            Context = context;
        }

        public IActionResult Index()
        {
            var home = new AboutPageViewModel()
            {
                HeaderViewModel = GetHeader(),
                Page = Context.AboutPageModels.FirstOrDefault()
            };
            home.HeaderViewModel.Title = home.HeaderViewModel.CompanyName;
            home.HeaderViewModel.CurrentPage = Menu.About;

            return View(home);
        }
    }
}