using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using Soulful.Models;
using Soulful.Services;

namespace Soulful.Controllers
{
    public class UserOrderDetailsController : Controller
    {
        // GET: CRUD
        [Authorize]
        public ActionResult Index()
        {
            var userId = HttpContext.User.Identity.GetUserId();
            OrderService orderService = new OrderService();
            var order = orderService.GetUserOrders(userId);
            return View(order.ToList());
        }

        // GET: CRUD/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OrderService orderService = new OrderService();
            var order = orderService.GetOrderById(id);
            if (order == null)
            {
                return HttpNotFound();
            }
            return View(order);
        }


    }
}
