using System.Collections.Generic;
using PhPopovich.Models;
using PhPopovich.Models.Pages;
using PhPopovich.ViewModels.Common;

namespace PhPopovich.ViewModels.Projects
{
    public class AllProjectsPageViewModel : CommonPageViewModel
    {
        public AllProjectsPageViewModel()
        {
            
        }

        public AllProjectsPageViewModel(HeaderViewModel headerViewModel, FooterViewModel footerViewModel) : base(headerViewModel, footerViewModel)
        {
            
        }
        
        public List<ProjectModel> ProjectModels { get; set; }
        
        public ProjectsPageModel ProjectsPageModel { get; set; }
    }
}
