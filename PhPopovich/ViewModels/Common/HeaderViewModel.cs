using System.Collections.Generic;
using PhPopovich.Models;
using PhPopovich.StaticHelpers;

namespace PhPopovich.ViewModels.Common
{
    public class HeaderViewModel
    {
        public string Title { get; set; }

        public string CompanyName { get; set; } = App.CompanyName;

        public Menu CurrentPage { get; set; }

        public List<MenuViewModel> Menus { get; set; }
    }
}
