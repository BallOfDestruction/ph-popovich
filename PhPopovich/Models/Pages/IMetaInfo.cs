namespace PhPopovich.Models.Pages
{
    public interface IMetaInfo
    {
        string MetaTitle { get; set; }
        
        string MetaDescription { get; set; }
                
        ImageModel MetaImageModel { get; set; }
    }
}