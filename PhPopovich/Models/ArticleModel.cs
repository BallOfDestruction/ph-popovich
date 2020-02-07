using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using PhPopovich.Controllers.cms;

namespace PhPopovich.Models
{
    public class ArticleModel : Entity<ArticleModel>
    {
        [DisplayName("Заголовок")]
        [Show]
        public override string Title { get; set; }

        [DisplayName("Статья")]
        [Show(false)]
        [DataType(DataType.Html)]
        public string Text { get; set; }

        [DisplayName("Подзаголовок")]
        [Show(false)]
        [DataType(DataType.Html)]
        public string Subtitle { get; set; }
        
        [Show(false)]
        [DisplayName("Порядок")]
        public override int Position { get; set; }


        [Show(false, false, false, false)]
        public Guid? ImageModelId { get; set; }

        [Show(false, false)]
        [DisplayName("Изображение")]
        [Required]
        public ImageModel ImageModel { get; set; }
    }
}