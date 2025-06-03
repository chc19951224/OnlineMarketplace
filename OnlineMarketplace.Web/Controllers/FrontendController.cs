using OnlineMarketplace.Services;
using OnlineMarketplace.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineMarketplace.Web.Controllers
{
    public class FrontendController : Controller
    {
        FrontendService frontendService = new FrontendService();

        public ActionResult FrontendIndex()
        {
            var viewModel = new FrontendViewModel.IndexViewModel
            {
                FeaturedCategoryBlock = frontendService.GetFeaturedCategoryBundle()
            };
            return View();
        }
    }
}