using EnglishApp.StaticHelpers;

namespace EnglishApp.ViewModels.Common
{
    public class HeaderViewModel
    {
        public string Title { get; set; }

        public string CompanyName { get; set; } = App.CompanyName;
    }
}
