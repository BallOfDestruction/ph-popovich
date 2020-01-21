using Microsoft.AspNetCore.Mvc;
using PhPopovich.Models;

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
            return View();
        }
    }
}
