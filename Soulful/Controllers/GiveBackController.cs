using Soulful.Services;
using Soulful.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Soulful.Controllers
{
    public class GiveBackController : Controller
    {
        public ActionResult CreateData(GiveBackViewModel giveBack)
        {
            AccountService service = new AccountService();
            service.CreateGiveBack(giveBack);

            return new EmptyResult();
        }
    }
}