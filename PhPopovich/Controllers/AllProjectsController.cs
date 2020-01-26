using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PhPopovich.Models;
using PhPopovich.ViewModels.Projects;

namespace PhPopovich.Controllers
{
    public class AllProjectsController : CommonController
    {
        public AllProjectsController(Context context)
        {
            Context = context;
        }

        public IActionResult Index()
        {
            var allProjects = new AllProjectsPageViewModel(GetHeader(), GetFooterViewModel());
            allProjects.HeaderViewModel.CurrentPage = Menu.Projects;
            allProjects.ProjectsPageModel = Context.ProjectsPageModels.FirstOrDefault();
            
            var projects = Context.ProjectModels
                .OrderBy(w => w.Position)
                .Include(w => w.ImageModel)
                .ToList();

            allProjects.ProjectModels = projects;
            
            return View(allProjects);
        }
    }
}