using PhPopovich.Models.Pages;
using PhPopovich.ViewModels.Common;

namespace PhPopovich.ViewModels.Contacts
{
    public class ContactsPageViewModel : PartialPageViewModel<ContactsPageModel>
    {
        public ContactsPageViewModel()
        {
            
        }

        public ContactsPageViewModel(ContactsPageModel contactsPageModel) : base(contactsPageModel)
        {
        }
    }
}
