using System.ComponentModel;
using PhPopovich.Controllers.cms;

namespace PhPopovich.Models
{
    [Access]
    public class MenuModel : Entity<MenuModel>
    {
        [DisplayName("Название")]
        public string Name { get; set; }

        [DisplayName("Ссылка")]
        public string Href { get; set; }

        [Show(false, false, false, false)]
        public Menu Menu { get; set; }

        [DisplayName("Позиция")]
        [Show]
        public override int Position { get; set; }
    }
}
