using PhPopovich.Models.Pages;
using PhPopovich.StaticHelpers;

namespace PhPopovich.ViewModels.Common
{
    public class FooterViewModel
    {
        public string CompanyName { get; set; } = App.CompanyName;

        public ContactsPageModel ContactsPageModel { get; set; }

        public FooterViewModel()
        {
            
        }

        public FooterViewModel(ContactsPageModel contactsPageModel)
        {
            ContactsPageModel = contactsPageModel;
        }
    }
}
