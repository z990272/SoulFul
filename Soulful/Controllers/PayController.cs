using Soulful.Models;
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
    public class PayController : Controller
    {
        // GET: Pay
        public ActionResult PayView()
        {
            return View();
        }
    }
}