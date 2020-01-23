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
                FooterViewModel = GetFooterViewModel(),
                Page = Context.ServicesPageModels.FirstOrDefault(),
            };
            home.HeaderViewModel.CurrentPage = Menu.Services;

            return View(home);
        }
    }
}