using System.Linq;
using App.Models;
using App.ViewModels.About;
using App.ViewModels.Contacts;
using App.ViewModels.Home;
using App.ViewModels.Projects;
using App.ViewModels.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace App.Controllers
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
                HeaderViewModel = GetHeaderViewModel(),
                FooterViewModel = GetFooterViewModel(),
                ContactsPageViewModel = new ContactsPageViewModel(Context.ContactsPageModels
                    .Include(w => w.EmailModels)
                    .Include(w => w.PhoneModels)
                    .FirstOrDefault()),
                Page = Context.MainPageModels
                    .Include(w => w.Images)
                    .Include(w => w.MetaImageModel)
                    .FirstOrDefault(),
                AboutPageViewModel = new AboutPageViewModel(Context.AboutPageModels.FirstOrDefault()),
                ServicesPageViewModel = new ServicesPageViewModel(Context.ServicesPageModels.FirstOrDefault()),
                ProjectsPageViewModel = new ProjectsPageViewModel(Context.ProjectsPageModels.FirstOrDefault()),
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

            home.ServicesPageViewModel.ServiceModels = services;
            home.ProjectsPageViewModel.ProjectModels = projects;

            home.HeaderViewModel.CurrentPage = Menu.Main;

            return View(home);
        }
    }
}
