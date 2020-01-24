using Microsoft.AspNetCore.Mvc;
using PhPopovich.Models;
using PhPopovich.ViewModels.Projects;

namespace PhPopovich.Controllers
{
    public class ProjectsController : CommonController
    {
        public ProjectsController(Context context)
        {
            Context = context;
        }

        public IActionResult Index()
        {
            var home = new AllProjectsPageViewModel(GetHeader(), GetFooterViewModel());
            home.HeaderViewModel.CurrentPage = Menu.Projects;

            return View(home);
        }
    }
}