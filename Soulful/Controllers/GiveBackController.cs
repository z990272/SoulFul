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
        AccountService _accountService;
        public GiveBackController()
        {
            _accountService = new AccountService();
        }
        public ActionResult CreateData(GiveBackViewModel giveBack)
        {
            _accountService.CreateGiveBack(giveBack);

            return new EmptyResult();
        }
    }
}