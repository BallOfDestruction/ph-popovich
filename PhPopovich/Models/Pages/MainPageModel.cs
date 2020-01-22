using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using PhPopovich.Controllers.cms;

namespace PhPopovich.Models.Pages
{
    [SingleObject]
    [Access(false, false, true, false)]
    public class MainPageModel : BasePage<MainPageModel>
    {
        [DisplayName("Основной текст")]
        [DataType(DataType.Html)]
        public string MainTitle { get; set; }

        [Show(false, false, false, false)]
        public Guid? ImageModelId { get; set; }

        [Show(false, false, true, true)]
        [DisplayName("Изображение")]
        public ImageModel ImageModel { get; set; }
    }
}
