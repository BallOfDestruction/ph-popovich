using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using PhPopovich.Controllers.cms;
using PhPopovich.Models.Pages;

namespace PhPopovich.Models
{
    [Access]
    public class PhoneModel : Entity<PhoneModel>
    {
        [DataType(DataType.PhoneNumber)]
        [DisplayName("Телефон")]
        public string Phone { get; set; }


        [Show(false, false, false, false)]
        public Guid? ContactsPageModelId { get; set; }

        [Show(false)]
        [DisplayName("Страница контактов")]
        public ContactsPageModel ContactsPageModel { get; set; }
    }
}