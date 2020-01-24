using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using PhPopovich.Controllers.cms;

namespace PhPopovich.Models.Pages
{
    [SingleObject]
    [Access(false, false, true, false)]
    public class ServicesPageModel : BasePage<ServicesPageModel>
    {
        [DisplayName("Что-нибудь о услугах")]
        [DataType(DataType.Html)]
        [Show(false)]
        public string ServicesText { get; set; }
    }
}