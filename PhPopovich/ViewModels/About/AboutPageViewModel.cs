using System.Collections.Generic;
using PhPopovich.Models.Pages;
using PhPopovich.ViewModels.Common;

namespace PhPopovich.ViewModels.About
{
    public class AboutPageViewModel : CommonPageViewModel<AboutPageModel>
    {
        public List<string> Phones { get; set; }

        public List<string> Emails { get; set; }
    }
}
