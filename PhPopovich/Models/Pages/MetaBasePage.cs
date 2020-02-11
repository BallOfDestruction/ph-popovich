using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using PhPopovich.Controllers.cms;

namespace PhPopovich.Models.Pages
{
    public abstract class MetaBasePage<T> : BasePage<T>, IMetaInfo
        where T : IEntity
    {
        [DisplayName("Мета заголовок")]
        [Show(false)]
        public virtual string MetaTitle { get; set; }
        
        [DisplayName("Мета описание")]     
        [Show(false)]
        public virtual string MetaDescription { get; set; }
                
        [Show(false, false, false, false)]
        public virtual Guid? MetaImageModelId { get; set; }

        [Show(false)]
        [DisplayName("Мета изображение")]
        [Required]
        public virtual ImageModel MetaImageModel { get; set; }
    }
}