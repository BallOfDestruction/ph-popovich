using System.ComponentModel;

namespace EnglishApp.Models.Pages
{
    public abstract class BasePage<T> : Entity<T>, IPage
        where T : IEntity
    {
        [DisplayName("Заголовок")]
        public string PageTitle { get; set; }
    }
}
