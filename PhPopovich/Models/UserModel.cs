using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using PhPopovich.Controllers.cms;

namespace PhPopovich.Models
{
    [Access]
    public class UserModel : Entity<UserModel>
    {
        [DisplayName("Логин")]
        public string Login { get; set; }

        [Show(false, false)]
        [DataType(DataType.Password)]
        [DisplayName("Пароль")]
        public string Password { get; set; }
    }
}
