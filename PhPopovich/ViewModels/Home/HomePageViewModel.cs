using PhPopovich.Models.Pages;
using PhPopovich.ViewModels.About;
using PhPopovich.ViewModels.Common;
using PhPopovich.ViewModels.Contacts;

namespace PhPopovich.ViewModels.Home
{
    public class HomePageViewModel : CommonPageViewModel<MainPageModel>
    {
        public ContactsPageViewModel ContactsPageViewModel { get; set; }

        public AboutPageViewModel AboutPageViewModel { get; set; }
    }
}
