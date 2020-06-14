using Microsoft.AspNet.Identity;
using Soulful.Models;
using Soulful.Repositories;
using Soulful.Services;
using Soulful.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Web;
using System.Web.Mvc;

namespace Soulful.Controllers
{
    public class OrderController : Controller
    {
        // GET: Pay
        public ActionResult Order()
        {
            var cartItems = (List<Soulful.ViewModels.CartViewModel>)Session["Cart"];
            if (cartItems != null)
            {
                var TotalAmount = cartItems.Sum(x => x.Price * x.Count);
                return View(TotalAmount);
            }
            decimal dec = 0;
            return View(dec);

        }
        public ActionResult ConfirmOrder()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ConfirmOrder([Bind(Include = "RecieverName,RecieverPhone,RecieverAdress")] OrderViewModel orderView)
        {
            OrderService orderService = new OrderService();

            if (ModelState.IsValid)
            {
                var userId = HttpContext.User.Identity.GetUserId();
                orderService.Create(orderView, userId);
                return RedirectToAction("Index");
            }

            //ViewBag.AspNetUsers_Id = new SelectList(db.AspNetUsers, "Id", "Email", order.AspNetUsers_Id);
            return View(orderView);
        }
    }
}