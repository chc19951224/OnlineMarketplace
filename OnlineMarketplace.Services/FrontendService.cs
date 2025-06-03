using OnlineMarketplace.DataAccess;
using OnlineMarketplace.Shared;
using OnlineMarketplace.Shared.Mappers;
using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineMarketplace.Services
{
    public class FrontendService
    {
        #region 【 分 類 】
        #region 【獲取熱門分類和附帶商品】
        public List<FrontendViewModel.FeaturedCategoryBundleDto> GetFeaturedCategoryBundle()
        {
            using (var context = new MarketplaceDbContext())
            {
                var hotCategories = context.Categories.Where(c => c.Featured == true).ToList();
                var listProducts = context.Products.Include(p => p.Category).ToList();

                var dtoBundle = hotCategories.Select(c => new FrontendViewModel.FeaturedCategoryBundleDto
                {
                    FeaturedCategoryId = c.Id,
                    FeaturedCategoryName = c.Name,
                    FeaturedCategoryImageUrl = c.ImageUrl,
                    FeaturedCategoryDescription = c.Description,
                    RelatedProducts = listProducts.Where(p => p.CategoryId == c.Id)
                        .Select(p => FrontedMapper.EntityToProductDto(p))
                        .ToList()
                }).ToList();

                return dtoBundle;
            }
        }
        #endregion

        #region 【獲取所有分類】
        public List<FrontendViewModel.CategoryDto> GetAllCategories()
        {
            using (var context = new MarketplaceDbContext())
            {
                var categories = context.Categories.ToList();
                return categories.Select(c => FrontedMapper.EntityToCategoryDto(c)).ToList();
            }
        }
        #endregion

        #region 【獲取熱門分類】
        public List<FrontendViewModel.CategoryDto> FindFeaturedCategories()
        {
            using (var context = new MarketplaceDbContext())
            {
                var featureCategories = context.Categories.Where(c => c.Featured == true).ToList();
                return featureCategories.Select(c => FrontedMapper.EntityToCategoryDto(c)).ToList();
            }
        }
        #endregion
        #endregion

        #region 【 商 品 】
        #region 【獲取所有商品】
        public List<FrontendViewModel.ProductDto> FindProducts()
        {
            using (var context = new MarketplaceDbContext())
            {
                var products = context.Products.Include(p => p.Category).Where(p => p.Featured == true).ToList();
                return products.Select(c => FrontedMapper.EntityToProductDto(c)).ToList();
            }
        }
        #endregion

        #region 【獲取熱門商品】
        public List<FrontendViewModel.ProductDto> FindFeaturedProducts()
        {
            using (var context = new MarketplaceDbContext())
            {
                var featureProducts = context.Products.Include(p => p.Category).Where(p => p.Featured == true).ToList();
                return featureProducts.Select(c => FrontedMapper.EntityToProductDto(c)).ToList();
            }
        }
        #endregion
        #endregion
    }
}
