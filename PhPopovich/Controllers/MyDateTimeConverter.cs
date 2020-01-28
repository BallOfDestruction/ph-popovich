using Newtonsoft.Json.Converters;

namespace PhPopovich.Controllers
{
    public class MyDateTimeConverter : IsoDateTimeConverter
    {
        public MyDateTimeConverter()
        {
            DateTimeFormat = "DD.MM.YYYY";
        }
    }
}