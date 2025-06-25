using OnlineMarketplace.Services;
using OnlineMarketplace.Shared.Mappers;
using OnlineMarketplace.Shared.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Mvc;

namespace OnlineMarketplace.Web.Controllers
{
    [RoutePrefix("Category/Api")]
    public class CategoryApiController : Controller
    {
        CategoryService categoryService = new CategoryService();

        #region 【 控 制 分 類 請 求 】
        #region 【 R1 分類表格查詢 】
        [HttpPost]
        [Route("GetCategoryApi")]
        public ActionResult GetCategoryApi(int pageNumber, int pageSize)
        {
            var result = categoryService.FindCategoryApi(pageNumber, pageSize);
            return Json(new { Success = true, JsonResult = result });
        }
        #endregion

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        #region 【 R2 關鍵字查詢 】
        //[HttpPost]
        //public ActionResult GetCategoryByKey(string searchValue, int pageSize, int pageNumber)
        //{
        //    bool isNumeric = int.TryParse(searchValue, out int testNumber);
        //    bool isValid = Regex.IsMatch(searchValue, @"^[\u4e00-\u9fa5a-zA-Z]+$");

        //    // 如果關鍵字是數字或是非法輸入
        //    if (isNumeric || !isValid)
        //    {
        //        return Json(new { Success = false, Message = "————————   查 無 符 合 的 數 據   ————————" });
        //    }

        //    var result = categoryService.FindCategoryByKey(searchValue, pageSize, pageNumber); // 執行查詢
        //    // 如果列表查詢結果長度爲零，代表是空列表
        //    if (result.Count == 0)
        //    {
        //        return Json(new { Success = false, Message = "————————   查 無 符 合 的 數 據   ————————" });
        //    }

        //    // 回傳列表查詢結果
        //    return Json(new { Success = true, Result = result });
        //}
        #endregion

        #region 【 R3 重置查詢 】
        [HttpPost]
        public ActionResult GetCategoryByReset()
        {
            var categories = categoryService.FindAllCategories();
            return Json(new { Success = true, Result = categories });
        }
        #endregion

        #region 【（2）新增分類表單數據提交】
        [HttpPost]
        public ActionResult CreateCategory(CategoryDTO.Category tableData, HttpPostedFileBase CategoryImageUrl)
        {
            try
            {
                if (CategoryImageUrl != null && CategoryImageUrl.ContentLength > 0)
                {
                    string fileName = Path.GetFileName(CategoryImageUrl.FileName);
                    string uniqueFileName = Guid.NewGuid().ToString() + Path.GetExtension(fileName);
                    string serverFilePath = Path.Combine(Server.MapPath("~/Content/Images/Categories/"), uniqueFileName);
                    CategoryImageUrl.SaveAs(serverFilePath);

                    tableData.CategoryImageUrl = "/Content/Images/Categories/" + uniqueFileName;
                }


                bool result = categoryService.AddCategory(tableData);
                if (result)
                {
                    return Json(new
                    {
                        Success = true,
                        Message = "新增分類成功！",
                        RedirectUrl = Url.Action("ManageCategoryPage", "Backend")
                    });
                }
                else
                {
                    return Json(new
                    {
                        Success = false,
                        Message = "新增分類失敗！分類名稱重複！",
                        RedirectUrl = Url.Action("ManageCategoryPage", "Backend")
                    });
                }
            }

            catch (Exception ex)
            {
                return Json(new { Success = false, Message = ex.Message });
            }
        }
        #endregion

        #region 【（3）修改分類表單數據提交】
        [HttpPost]
        public ActionResult UpdateCategory(CategoryDTO.Category tableData, HttpPostedFileBase CategoryImageUrl)
        {
            try
            {
                if (CategoryImageUrl != null && CategoryImageUrl.ContentLength > 0)
                {
                    string fileName = Path.GetFileName(CategoryImageUrl.FileName);
                    string uniqueFileName = Guid.NewGuid().ToString() + Path.GetExtension(fileName);
                    string serverFilePath = Path.Combine(Server.MapPath("~/Content/Images/Categories/"), uniqueFileName);
                    CategoryImageUrl.SaveAs(serverFilePath);

                    tableData.CategoryImageUrl = "/Content/Images/Categories/" + uniqueFileName;
                }
                else
                {
                    var originTableData = categoryService.FindCategoryById(tableData.CategoryId);
                    tableData.CategoryImageUrl = originTableData.CategoryImageUrl;
                }

                bool result = categoryService.ModifyCategory(tableData);
                if (result)
                {
                    return Json(new
                    {
                        Success = true,
                        Message = "更新分類成功！",
                        RedirectUrl = Url.Action("ManageCategoryPage", "Backend")
                    });
                }
                else
                {
                    return Json(new
                    {
                        Success = false,
                        Message = "更新分類失敗！沒有找到該分類！",
                        RedirectUrl = Url.Action("ManageCategoryPage", "Backend")
                    });
                }
            }

            catch (Exception ex)
            {
                return Json(new { Success = false, Message = ex.Message });
            }
        }
        #endregion

        #region 【（4）刪除分類主鍵數據提交】
        [HttpPost]
        public ActionResult DeleteCategory(int categoryDtoId)
        {
            try
            {
                bool result = categoryService.RemoveCategoryById(categoryDtoId);
                if (result)
                {
                    return Json(new { Success = true, Message = "刪除分類成功！" });
                }
                else
                {
                    return Json(new { Success = false, Message = "刪除分類失敗！沒有找到該分類！" });
                }
            }
            catch (Exception ex)
            {
                return Json(new { Success = false, Message = ex.Message });
            }
        }
        #endregion
        # endregion
    }
}