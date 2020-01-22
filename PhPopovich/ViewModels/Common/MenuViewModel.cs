namespace PhPopovich.ViewModels.Common
{
    public class MenuViewModel
    {
        public string Title { get; set; }

        public string Href { get; set; }

        public bool IsCurrent { get; set; }

        public MenuViewModel()
        {
            
        }

        public MenuViewModel(string title, string href, bool isCurrent = false)
        {
            Title = title;
            Href = href;
            IsCurrent = isCurrent;
        }
    }
}