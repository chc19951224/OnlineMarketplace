using OnlineMarketplace.Repositories;
using OnlineMarketplace.Shared;
using OnlineMarketplace.Shared.Mappers;
using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineMarketplace.Shared.Models;

namespace OnlineMarketplace.Services
{
    public class FrontendService
    {
        #region 【 前 端 首 頁 業 務 邏 輯 】
        // FR1 獲取熱門分類和附帶商品
        //public List<FrontendViewModel.FeaturedCategoryBundleDto> GetFeaturedCategoryBundle()
        //{
        //    using (var context = new MarketplaceDbContext())
        //    {
        //        var hotCategories = context.Categories.Where(c => c.Featured == true).ToList();
        //        var listProducts = context.Products.Include(p => p.Category).ToList();

        //        var dtoBundle = hotCategories.Select(c => new FrontendViewModel.FeaturedCategoryBundleDto
        //        {
        //            FeaturedCategoryId = c.Id,
        //            FeaturedCategoryName = c.Name,
        //            FeaturedCategoryImageUrl = c.ImageUrl,
        //            FeaturedCategoryDescription = c.Description,
        //            RelatedProducts = listProducts.Where(p => p.CategoryId == c.Id)
        //                .Select(ProductMapper.EntityToProductDto)
        //                .ToList()
        //        }).ToList();

        //        return dtoBundle;
        //    }
        //}

        // FR2 獲取熱門分類
        //public List<CategoryDTO.Category> FindFeaturedCategories()
        //{
        //    using (var context = new MarketplaceDbContext())
        //    {
        //        var featureCategories = context.Categories.Where(c => c.Featured == true).ToList();
        //        return featureCategories.Select(c => CategoryMapper.EntityToCategoryDto(c)).ToList();
        //    }
        //}
        #endregion
    }
}
