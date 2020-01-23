using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
                FooterViewModel = GetFooterViewModel(),
                Page = Context.AboutPageModels.FirstOrDefault()
            };
            home.HeaderViewModel.CurrentPage = Menu.About;

            return View(home);
        }
    }
}