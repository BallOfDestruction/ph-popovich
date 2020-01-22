using System.Linq;
using Microsoft.AspNetCore.Mvc;
using PhPopovich.Models;
using PhPopovich.ViewModels.Contacts;

namespace PhPopovich.Controllers
{
    public class ContactsController : CommonController
    {
        public ContactsController(Context context)
        {
            Context = context;
        }

        public IActionResult Index()
        {
            var home = new ContactsPageViewModel()
            {
                HeaderViewModel = GetHeader(),
                Page = Context.ContactsPageModels.FirstOrDefault(),
            };
            home.HeaderViewModel.Title = home.HeaderViewModel.CompanyName;
            home.HeaderViewModel.CurrentPage = Menu.Contacts;

            return View(home);
        }
    }
}