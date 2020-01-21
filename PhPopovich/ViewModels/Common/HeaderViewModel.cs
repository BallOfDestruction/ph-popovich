using PhPopovich.StaticHelpers;

namespace PhPopovich.ViewModels.Common
{
    public class HeaderViewModel
    {
        public string Title { get; set; }

        public string CompanyName { get; set; } = App.CompanyName;
    }
}
