using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PhPopovich.Models;
using PhPopovich.ViewModels.Common;
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
                HeaderViewModel = new HeaderViewModel()
                {
                    Menus = new List<MenuViewModel>()
                    {
                        new MenuViewModel("Главная страница", "/", true),
                        new MenuViewModel("О нас", "/about"),
                        new MenuViewModel("Заказать фотосессию", "/orderPhoto"),
                        new MenuViewModel("Услуги", "/services"),
                        new MenuViewModel("Работы", "/projects"),
                        new MenuViewModel("Контакты", "/contacts"),
                        new MenuViewModel("Блог", "/blog"),
                    }
                },
                Page = Context.MainPageModels.Include(w => w.ImageModel).FirstOrDefault()
            };
            home.HeaderViewModel.Title = home.HeaderViewModel.CompanyName;

            return View(home);
        }
    }
}
