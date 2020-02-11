using PhPopovich.Models;
using PhPopovich.ViewModels.Common;

namespace PhPopovich.ViewModels.Projects
{
    public class ProjectPageViewModel : CommonPageViewModel<ProjectModel>
    {
        public ProjectPageViewModel()
        {
            
        }

        public ProjectPageViewModel(ProjectModel page, HeaderViewModel headerViewModel, FooterViewModel footerViewModel) 
            : base(page, headerViewModel, footerViewModel)
        {
            
        }
    }
}