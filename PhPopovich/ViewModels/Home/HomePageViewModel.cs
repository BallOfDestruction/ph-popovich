using System.Collections.Generic;
using PhPopovich.Models;
using PhPopovich.Models.Pages;
using PhPopovich.ViewModels.About;
using PhPopovich.ViewModels.Common;
using PhPopovich.ViewModels.Contacts;
using PhPopovich.ViewModels.Projects;
using PhPopovich.ViewModels.Services;

namespace PhPopovich.ViewModels.Home
{
    public class HomePageViewModel : CommonPageViewModel<MainPageModel>
    {
        public ContactsPageViewModel ContactsPageViewModel { get; set; }

        public AboutPageViewModel AboutPageViewModel { get; set; }

        public ServicesPageViewModel ServicesPageViewModel { get; set; }

        public ProjectsPageViewModel ProjectsPageViewModel { get; set; }

        public List<ServiceModel> Services { get; set; }

        public List<ProjectModel> Projects { get; set; }
    }
}
