using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PhPopovich.Models;
using PhPopovich.ViewModels.About;
using PhPopovich.ViewModels.Contacts;
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
                FooterViewModel = GetFooterViewModel(),
                ContactsPageViewModel = new ContactsPageViewModel(Context.ContactsPageModels
                    .Include(w => w.EmailModels)
                    .Include(w => w.PhoneModels)
                    .FirstOrDefault()),
                Page = Context.MainPageModels.Include(w => w.ImageModel).FirstOrDefault(),
                AboutPageViewModel = new AboutPageViewModel(Context.AboutPageModels.FirstOrDefault())
            };

            home.HeaderViewModel.CurrentPage = Menu.Main;

            return View(home);
        }
    }
}
