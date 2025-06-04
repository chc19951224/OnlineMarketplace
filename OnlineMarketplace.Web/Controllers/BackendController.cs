using OnlineMarketplace.Services;
using OnlineMarketplace.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineMarketplace.Web.Controllers
{
    public class BackendController : Controller
    {
        public ActionResult BackendIndex()
        {
            return View();
        }
    }
}