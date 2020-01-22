using PhPopovich.Controllers.cms;

namespace PhPopovich.Models
{
    [Access(false, false, false, false)]
    public class MenuModel : Entity<MenuModel>
    {
        public string Name { get; set; }

        public string Href { get; set; }

        public Menu Menu { get; set; }
    }
}
