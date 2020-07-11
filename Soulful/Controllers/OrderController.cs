using ECPay.Payment.Integration;
using Microsoft.AspNet.Identity;
using Soulful.Models;
using Soulful.Repositories;
using Soulful.Services;
using Soulful.ViewModels;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;

namespace Soulful.Controllers
{
    public class OrderController : Controller
    {
        private static List<CartViewModel> cartItem;
        private static OrderViewModel order;

        // GET: Pay
        [Authorize]
        public ActionResult Order()
        {
            ShoppingService shoppingService = new ShoppingService();
            var cartItems = (List<CartViewModel>)Session["Cart"];

            if (cartItems != null)
            {
                var TotalAmount = shoppingService.GetTotalAmount();
                return View(TotalAmount);
            }
            return View(0);

        }
        [Authorize]
        public ActionResult ConfirmOrder()
        {
            return View();
        }
        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ConfirmOrder(OrderViewModel orderView)
        {
            OrderService orderService = new OrderService();
            var cartItems = (List<CartViewModel>)Session["Cart"];
            if (ModelState.IsValid)
            {
                cartItem = cartItems;
                order = orderView;
                return Redirect("~/AioCheckOut.aspx");
            }

            return View(orderView);
        }

        public ActionResult Completed()
        {
            OrderService orderService = new OrderService();
            var FeedBack = orderService.GetEcPayOrderDetail();
            if (FeedBack.RtnMsg == "Succeeded")
            {
                var userId = HttpContext.User.Identity.GetUserId();
                orderService.Create(order, userId, cartItem);
            }
            else
            {
                FeedBack.TradeDate = "交易失敗";
                FeedBack.TradeNo = "交易失敗";
            }
            return View(FeedBack);
        }

        [AcceptVerbs("GET", "POST")]
        public ActionResult GetOrderNumber(string Email)
        {
            //var Email = "Allen321@gmail.com";
            OrderService orderService = new OrderService();
            var order = orderService.GetUserOrdersByEmail(Email);

            //JsonDataApi/GetCarSalesNumber


            return Json(order, JsonRequestBehavior.AllowGet);

        }
        [AcceptVerbs("GET", "POST")]
        public ActionResult GetWeekHotProduct()
        {
        
            ProductService productService = new ProductService();
            var WeekHot = productService.GetWeekHits();

  

            return Json(WeekHot, JsonRequestBehavior.AllowGet);

        }

    }
}

