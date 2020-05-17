using App.CMS;
using App.CMS.Controllers;
using App.CMS.Repositories.CmsModels;
using App.CMS.Repositories.File;
using App.CMS.Repositories.Image;
using App.Models;
using Microsoft.AspNetCore.Hosting;

namespace App.Controllers
{
    public class HomeCmsController : HomeCmsController<Context>
    {
        public HomeCmsController(Context context, IWebHostEnvironment appEnvironment, CMSOptions cmsOptions, ICmsImageModelRepository imageRepository, ICmsFilesRepository filesRepository, ICmsCmsModelRepository cmsCmsModelRepository) : base(context, appEnvironment, cmsOptions, imageRepository, filesRepository, cmsCmsModelRepository)
        {
        }
    }
}