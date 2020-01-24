using System.Collections.Generic;
using PhPopovich.Models;
using PhPopovich.Models.Pages;
using PhPopovich.ViewModels.Common;

namespace PhPopovich.ViewModels.Projects
{
    public class ProjectsPageViewModel : PartialPageViewModel<ProjectsPageModel>
    {
        public ProjectsPageViewModel()
        {

        }

        public ProjectsPageViewModel(ProjectsPageModel projectsPageModel) : base(projectsPageModel)
        {

        }
        
        public List<ProjectModel> ProjectModels { get; set; }
    }
}