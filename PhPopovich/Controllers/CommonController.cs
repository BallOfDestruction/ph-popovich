using System.Linq;
using Microsoft.AspNetCore.Mvc;
using PhPopovich.Models;
using PhPopovich.ViewModels.Common;

namespace PhPopovich.Controllers
{
    public class CommonController : Controller
    {
        protected Context Context { get; set; }

        protected HeaderViewModel GetHeader()
        {
            return new HeaderViewModel()
            {
                CurrentPage = Menu.Main,
                Menus = Context.Menus.OrderBy(w => w.Position).ToList()
                    .Select(w => new MenuViewModel(w.Name, w.Href, w.Menu)).ToList(),
            };
        }
    }
}
