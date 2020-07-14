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
        ShoppingService _shoppingService;
        OrderService _orderService;
        ProductService _productService;
        public OrderController()
        {
            _shoppingService = new ShoppingService();
            _orderService = new OrderService();
            _productService = new ProductService();
        }

        // GET: Pay
        [Authorize]
        public ActionResult Order()
        {
            var cartItems = (List<CartViewModel>)Session["Cart"];

            if (cartItems != null)
            {
                var TotalAmount = _shoppingService.GetTotalAmount();
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
            OrderService _orderService = new OrderService();
            var FeedBack = _orderService.GetEcPayOrderDetail();
            if (FeedBack.RtnMsg == "Succeeded")
            {
                var userId = HttpContext.User.Identity.GetUserId();
                _orderService.Create(order, userId, cartItem);
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

            var order = _orderService.GetUserOrdersByEmail(Email);

            return Json(order, JsonRequestBehavior.AllowGet);

        }
        [AcceptVerbs("GET", "POST")]
        public ActionResult GetWeekHotProduct()
        {

            var WeekHot = _productService.GetWeekHits();

            return Json(WeekHot, JsonRequestBehavior.AllowGet);

        }

    }
}

