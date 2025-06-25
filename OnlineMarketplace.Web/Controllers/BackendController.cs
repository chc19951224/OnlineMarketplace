using OnlineMarketplace.Services;
using OnlineMarketplace.Shared;
using OnlineMarketplace.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineMarketplace.Web.Controllers
{
    public class BackendController : Controller
    {
        #region 【 控 制 前 端 頁 面 】

        #region 【 全 局 變 量 】
        BackendService backendService = new BackendService();
        CategoryService categoryService = new CategoryService();
        #endregion

        #region 【 後 端 首 頁 】
        public ActionResult BackendIndex()
        {
            var viewModel = new BackendViewModel.IndexViewModel
            {
                Panel = backendService.GetPanelStatistics()
            };
            return View(viewModel);
        }
        #endregion

        #region 【 管 理 分 類 頁 】
        public ActionResult ManageCategoryPage()
        {
            return View();
        }
        #endregion

        #region 【 新 增 分 類 頁 】
        public ActionResult CreateCategoryPage()
        {
            return View();
        }
        #endregion

        #region 【 更 新 分 類 頁 】
        public ActionResult UpdateCategoryPage(int id)
        {
            var viewModel = new CategoryViewModel.UpdateCategoryViewModel
            {
                Category = categoryService.FindCategoryById(id)
            };
            return View(viewModel);
        }
        #endregion
        #endregion
    }
}