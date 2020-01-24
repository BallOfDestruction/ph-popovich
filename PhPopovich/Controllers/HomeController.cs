using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PhPopovich.Models;
using PhPopovich.Models.Pages;
using PhPopovich.ViewModels.About;
using PhPopovich.ViewModels.Contacts;
using PhPopovich.ViewModels.Home;
using PhPopovich.ViewModels.Services;

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
                AboutPageViewModel = new AboutPageViewModel(Context.AboutPageModels.FirstOrDefault()),
                ServicesPageViewModel = new ServicesPageViewModel(Context.ServicesPageModels.FirstOrDefault())
            };

            var services = Context.ServiceModels
                .OrderBy(w => w.Position)
                .Include(w => w.ImageModel)
                .Take(home.Page?.ServicesCount ?? 0)
                .ToList();

            var projects = Context.ProjectModels
                .OrderBy(w => w.Position)
                .Include(w => w.ImageModel)
                .Take(home.Page?.ProjectsCount ?? 0)
                .ToList();

            home.Services = services;
            home.Projects = projects;

            home.HeaderViewModel.CurrentPage = Menu.Main;

            return View(home);
        }
    }
}
