using Microsoft.AspNet.Identity;
using Soulful.Models;
using Soulful.Repositories;
using Soulful.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Soulful.Services
{
    public class OrderService
    {
        SoulfulContext context = new SoulfulContext();
        public void Create(OrderViewModel orderView, string userId)
        {
            SoulfulRepository<Order> repository = new SoulfulRepository<Order>(context);

            Order order = new Order()
            {
                RecieverName = orderView.RecieverName,
                RecieverPhone = orderView.RecieverPhone,
                RecieverAdress = orderView.RecieverAdress,
                Datetime = DateTime.Now,
                AspNetUsers_Id = userId

            };



            //repository.Create(order);

            //context.SaveChanges();
        }
    }
}