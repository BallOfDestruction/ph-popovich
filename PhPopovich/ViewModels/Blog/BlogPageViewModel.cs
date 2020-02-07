using System.Collections.Generic;
using PhPopovich.Models;
using PhPopovich.Models.Pages;
using PhPopovich.ViewModels.Common;

namespace PhPopovich.ViewModels.Blog
{
    public class BlogPageViewModel : CommonPageViewModel<BlogPageModel>
    {
        public List<ArticleModel> ArticleModels { get; set; }
    }
}
