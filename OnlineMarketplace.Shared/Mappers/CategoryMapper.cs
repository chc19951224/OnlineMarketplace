using OnlineMarketplace.Entities;
using OnlineMarketplace.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace OnlineMarketplace.Shared.Mappers
{
    public static class CategoryMapper
    {
        #region 【 分 類 映 射 類 】
        #region 【 分類表達式樹 】
        // 實體對象 ===> 數據傳輸對象 
        public static readonly Expression<Func<Category, CategoryDTO.Category>> EntityToCategoryDto =
            entity => new CategoryDTO.Category
            {
                CategoryId = entity.Id,
                CategoryName = entity.Name,
                CategoryImageUrl = entity.ImageUrl,
                CategoryDescription = entity.Description,
                FeaturedCategory = entity.Featured
            };
        #endregion

        #region 【 分類映射方法 】
        // 數據傳輸對象 ===> 實體對象
        public static Category CategoryDtoToEntity(CategoryDTO.Category dto)
        {
            return new Category
            {
                Id = dto.CategoryId,
                Name = dto.CategoryName,
                ImageUrl = dto.CategoryImageUrl,
                Description = dto.CategoryDescription,
                Featured = dto.FeaturedCategory
            };
        }
        #endregion
        #endregion
    }
}
