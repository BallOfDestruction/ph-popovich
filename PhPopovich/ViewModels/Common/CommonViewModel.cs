using PhPopovich.Models.Pages;

namespace PhPopovich.ViewModels.Common
{
    public class CommonPageViewModel
    {
        public HeaderViewModel HeaderViewModel { get; set; }

        public FooterViewModel FooterViewModel { get; set; }

        public CommonPageViewModel()
        {
            
        }

        public CommonPageViewModel(HeaderViewModel headerViewModel, FooterViewModel footerViewModel)
        {
            HeaderViewModel = headerViewModel;
            FooterViewModel = footerViewModel;
        }

        public virtual IMetaInfo GetMetaPage()
        {
            return null;
        }
    }
}
