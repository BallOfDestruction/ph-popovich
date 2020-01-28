using System;
using System.ComponentModel;
using PhPopovich.Controllers.cms;

namespace PhPopovich.Models
{
    [Access]
    public class OrderModel : Entity<OrderModel>
    {
        [DisplayName("Имя Фамилия")]
        public string Name { get; set; }
        
        [DisplayName("Емайл или телефон")]
        public string EmailOrPhone { get; set; }
        
        [DisplayName("Желаемая дата")]
        public DateTime DesireDate { get; set; }
        
        [DisplayName("Что конкретно хотелось бы")]
        public string About { get; set; }
    }
}