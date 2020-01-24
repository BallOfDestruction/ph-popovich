using System.Collections.Generic;
using PhPopovich.Models.Pages;
using PhPopovich.ViewModels.Common;

namespace PhPopovich.ViewModels.About
{
    public class AboutPageViewModel : PartialPageViewModel<AboutPageModel>
    {
        public AboutPageViewModel()
        {
            
        }

        public AboutPageViewModel(AboutPageModel aboutPageModel) : base(aboutPageModel)
        {
            
        }
    }
}
