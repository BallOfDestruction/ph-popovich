using System.ComponentModel;
using PhPopovich.Controllers.cms;

namespace PhPopovich.Models
{
    [Access(false, false,true,false)]
    public class CmsModel : Entity<CmsModel>
    {
        [DisplayName("Заголовок")]
        [Show]
        public override string Title { get; set; }

        [DisplayName("Позиция")]
        [Show]
        public int Position { get; set; }

        [Show(false,false,false,false)]
        public string Class { get; set; }

        [Show(false, false, false, false)]
        public int NewCount { get; set; }

        [Show(false, false, false, false)]
        public bool IsSinglePage { get; set; }
    }
}
