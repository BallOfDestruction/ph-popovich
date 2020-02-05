using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using PhPopovich.Controllers.cms;
using PhPopovich.Models.Pages;

namespace PhPopovich.Models
{
    [Access(false, false, false, false)]
    public class ImageModel : Entity<ImageModel>
    {
        [DataType(DataType.ImageUrl)]
        [DisplayName("Ссылка на диске")]
        public string Url { get; set; }

        public string ImageType { get; set; }

        public string Extension { get; set; }


        [Show(false, false, false, false)]
        public Guid? MainPageModelGalleryId { get; set; }

        [Show(false, false, false, false)]
        public MainPageModel MainPageModelGallery { get; set; }


        [Show(false, false, false, false)]
        public Guid? ServiceModelId { get; set; }

        public ServiceModel ServiceModel{ get; set; }


        [Show(false, false, false, false)]
        public Guid? ProjectModelId { get; set; }

        public ProjectModel ProjectModel { get; set; }
    }
}
