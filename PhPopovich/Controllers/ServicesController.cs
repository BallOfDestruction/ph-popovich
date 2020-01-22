using System.Linq;
using Microsoft.AspNetCore.Mvc;
using PhPopovich.Models;
using PhPopovich.ViewModels.Services;

namespace PhPopovich.Controllers
{
    public class ServicesController : CommonController
    {
        public ServicesController(Context context)
        {
            Context = context;
        }

        public IActionResult Index()
        {
            var home = new ServicesPageViewModel()
            {
                HeaderViewModel = GetHeader(),
                Page = Context.ServicesPageModels.FirstOrDefault(),
            };
            home.HeaderViewModel.Title = home.HeaderViewModel.CompanyName;
            home.HeaderViewModel.CurrentPage = Menu.Services;

            return View(home);
        }
    }
}