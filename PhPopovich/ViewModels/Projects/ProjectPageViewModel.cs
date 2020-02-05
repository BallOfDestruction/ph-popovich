using PhPopovich.Models;
using PhPopovich.ViewModels.Common;

namespace PhPopovich.ViewModels.Projects
{
    public class ProjectPageViewModel : CommonPageViewModel
    {
        public ProjectPageViewModel()
        {
            
        }

        public ProjectPageViewModel(HeaderViewModel headerViewModel, FooterViewModel footerViewModel) : base(headerViewModel, footerViewModel)
        {
            
        }
        
        public ProjectModel ProjectModel { get; set; }
    }
}