using Microsoft.AspNetCore.Mvc;
using PhPopovich.Models;

namespace PhPopovich.Controllers
{
    public class CommonController : Controller
    {
        protected Context Context { get; set; }
    }
}
