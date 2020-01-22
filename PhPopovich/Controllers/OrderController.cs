using System.Linq;
using Microsoft.AspNetCore.Mvc;
using PhPopovich.Models;
using PhPopovich.ViewModels.Order;

namespace PhPopovich.Controllers
{
    public class OrderController : CommonController
    {
        public OrderController(Context context)
        {
            Context = context;
        }

        public IActionResult Index()
        {
            var home = new OrderPageViewModel()
            {
                HeaderViewModel = GetHeader(),
                Page = Context.OrderPageModels.FirstOrDefault(),
            };
            home.HeaderViewModel.Title = home.HeaderViewModel.CompanyName;
            home.HeaderViewModel.CurrentPage = Menu.Order;

            return View(home);
        }
    }
}