using Microsoft.AspNet.Identity;
using Soulful.Models;
using Soulful.Repositories;
using Soulful.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebGrease.Css.Extensions;

namespace Soulful.Services
{
    public class OrderService
    {
        private SoulfulContext context = new SoulfulContext();
        public void Create(OrderViewModel orderView, string userId, List<CartViewModel> cartItems)
        {
            SoulfulRepository<Order> O_Repository = new SoulfulRepository<Order>(context);
            SoulfulRepository<OrderDetail> Od_Repository = new SoulfulRepository<OrderDetail>(context);

            Order order = new Order()
            {
                RecieverName = orderView.RecieverName,
                RecieverPhone = orderView.RecieverPhone,
                RecieverAdress = orderView.RecieverAdress,
                Datetime = DateTime.Now,
                AspNetUsers_Id = userId
            };


            O_Repository.Create(order);

            context.SaveChanges();


            cartItems.ForEach(item =>
            {
                OrderDetail orderDetail = new OrderDetail()
                {
                    Order_id = order.Order_id,
                    Album_id = item.Id,
                    Count = item.Count,
                    Price = item.Price
                };

                Od_Repository.Create(orderDetail);

                context.SaveChanges();
            });
        }
    }
}