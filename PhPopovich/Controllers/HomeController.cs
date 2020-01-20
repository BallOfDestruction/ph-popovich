using EnglishApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace EnglishApp.Controllers
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
