using System.ComponentModel;
using EnglishApp.Controllers.cms;

namespace EnglishApp.Models
{
    [Access]
    public class WordModel : Entity<WordModel>
    {
        [DisplayName("Слово")]
        public string OriginalWord { get; set; }

        [DisplayName("Перевод")]
        public string Translate { get; set; }

        [DisplayName("Описание")]
        public string Description { get; set; }

        [DisplayName("Дополнительно")]
        [Show(false)]
        public string Addition { get; set; }
    }
}
