using System.Linq;
using Microsoft.AspNetCore.Mvc;
using PhPopovich.Models;
using PhPopovich.ViewModels.Services;

namespace PhPopovich.Controllers
{
    public class AllServicesController : CommonController
    {
        public AllServicesController(Context context)
        {
            Context = context;
        }

        public IActionResult Index()
        {
            var home = new AllServicesPageViewModel(GetHeader(), GetFooterViewModel());
            home.HeaderViewModel.CurrentPage = Menu.Services;

            return View(home);
        }
    }
}