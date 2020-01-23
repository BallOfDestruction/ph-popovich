using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
                FooterViewModel = GetFooterViewModel(),
                Page = Context.ContactsPageModels
                    .Include(w => w.EmailModels)
                    .Include(w => w.PhoneModels)
                    .FirstOrDefault(),
            };
            home.HeaderViewModel.CurrentPage = Menu.Contacts;

            return View(home);
        }
    }
}