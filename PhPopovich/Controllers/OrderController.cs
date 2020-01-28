using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PhPopovich.Models;
using PhPopovich.StaticHelpers;
using EmailModel = PhPopovich.StaticHelpers.EmailModel;

namespace PhPopovich.Controllers
{
    public class OrderController : CommonController
    {
        public OrderController(Context context)
        {
            Context = context;
        }
 
        [HttpPost]
        public async Task<IActionResult> MakeOrder(OrderViewModel orderViewModel)
        {
            var orderModel = new OrderModel()
            {
                About = orderViewModel.About,
                Name = orderViewModel.Name,
                DesireDate = orderViewModel.DesireDate,
                EmailOrPhone = orderViewModel.EmailOrPhone
            };

            await Context.OrderModels.AddAsync(orderModel);
            await Context.SaveChangesAsync();

            var text = $"Контакная информация:{orderModel.EmailOrPhone}\n" +
                       $"Имя фамилия:{orderModel.Name}\n" +
                       $"Желаемая дата:{orderModel.DesireDate.ToShortDateString()}" +
                       $"\nЧто конкретно хочет:{orderModel.About}";
            
            EmailService.Send(new EmailModel()
            {
                From = "support@ph-popovich.com",
                To = "support@ph-popovich.com",
                Subject = "Новый заказ",
                Body = text
            });
            
            return RedirectToAction("Index", "Home");
        }
    }
}