using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace PhPopovich.Controllers
{
    public class OrderViewModel
    { 
        [Required]
        [DisplayName("Имя фамилия")]
        public string Name { get; set; }
        
        [Required]
        [DisplayName("Телефон или почта")]
        public string EmailOrPhone { get; set; }
        
        [Required]
        [DataType(DataType.Date)]
        [JsonConverter(typeof(MyDateTimeConverter))]
        [DisplayName("Желаемая дата")]
        public DateTime DesireDate { get; set; } = DateTime.Now.AddDays(1);
        
        [Required]
        [DisplayName("Чтобы вы хотели")]
        public string About { get; set; }
    }
}