using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using PhPopovich.Controllers.cms;

namespace PhPopovich.ViewModels.Comment
{
    public class CommentViewModel
    {
        [DisplayName("Имя")]
        [Required(ErrorMessage = "Укажите свое имя")]
        public string Name { get; set; }
        
        [Show(false)]
        [DisplayName("Комментарий")]
        [Required(ErrorMessage = "Напишите ваш комментарий")]
        public string Text { get; set; }
        
        public Guid ArticleId { get; set; }
    }
}