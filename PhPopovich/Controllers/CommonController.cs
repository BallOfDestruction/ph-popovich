using EnglishApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace EnglishApp.Controllers
{
    public class CommonController : Controller
    {
        protected Context Context { get; set; }
    }
}
