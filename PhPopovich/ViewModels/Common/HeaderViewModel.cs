using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using PhPopovich.Models;
using PhPopovich.Models.Pages;
using PhPopovich.StaticHelpers;

namespace PhPopovich.ViewModels.Common
{
    public class HeaderViewModel
    {
        public IMetaInfo MetaInfo { get; set; }

        public string CompanyName { get; set; } = App.CompanyName;

        public Menu CurrentPage { get; set; }

        public List<MenuViewModel> Menus { get; set; }

        public string GetMetaImageUrl(HttpRequest httpRequest)
        {
            return MetaInfo?.MetaImageModel?.GetFullUrl(httpRequest);
        }
    }
}
