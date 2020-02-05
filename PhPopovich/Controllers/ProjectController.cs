using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PhPopovich.Models;
using PhPopovich.ViewModels.Projects;

namespace PhPopovich.Controllers
{
    public class ProjectController : CommonController
    {
        public ProjectController(Context context)
        {
            Context = context;
        }

        public IActionResult Index(Guid id)
        {
            var projects = new ProjectPageViewModel(GetHeader(), GetFooterViewModel());
            projects.ProjectModel = Context.ProjectModels
                .Include(w => w.ImageModel)
                .Include(w => w.Images)
                .FirstOrDefault(w => w.Id == id);

            return View(projects);
        }
    }
}