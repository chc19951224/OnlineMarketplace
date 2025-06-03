using OnlineMarketplace.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineMarketplace.Shared.Mappers
{
    public static class FrontedMapper
    {
        #region 【 分 類 】
        // 映射 實體分類對象 ===> 分類傳輸對象
        public static FrontendViewModel.CategoryDto EntityToCategoryDto(Category categoryEntity)
        {
            return new FrontendViewModel.CategoryDto
            {
                CategoryId = categoryEntity.Id,
                CategoryName = categoryEntity.Name,
                CategoryImageUrl = categoryEntity.ImageUrl,
                CategoryDescription = categoryEntity.Description,
                FeaturedCategory = categoryEntity.Featured
            };
        }

        // 映射 分類傳輸對象 ===> 實體分類對象
        public static Category CategoryDtoToEntity(FrontendViewModel.CategoryDto categoryDto)
        {
            return new Category
            {
                Id = categoryDto.CategoryId,
                Name = categoryDto.CategoryName,
                ImageUrl = categoryDto.CategoryImageUrl,
                Description = categoryDto.CategoryDescription,
                Featured = categoryDto.FeaturedCategory
            };
        }
        #endregion

        #region 【 商 品 】
        // 映射 商品實體對象 ===> 商品傳輸對象
        public static FrontendViewModel.ProductDto EntityToProductDto(Product productEntity)
        {
            return new FrontendViewModel.ProductDto
            {
                RelatedCategoryId = productEntity.CategoryId,
                RelatedCategory = EntityToCategoryDto(productEntity.Category),
                ProductId = productEntity.Id,
                ProductName = productEntity.Name,
                ProductImageUrl = productEntity.ImageUrl,
                ProductPrice = productEntity.Price,
                ProductDescription = productEntity.Description,
                FeaturedProduct = productEntity.Featured
            };
        }

        // 映射 商品傳輸對象 ===> 商品實體對象
        public static Product ProductDtoToEntity(FrontendViewModel.ProductDto productDto)
        {
            return new Product
            {
                CategoryId = productDto.RelatedCategoryId,
                Category = CategoryDtoToEntity(productDto.RelatedCategory),
                Id = productDto.ProductId,
                Name = productDto.ProductName,
                ImageUrl = productDto.ProductImageUrl,
                Description = productDto.ProductDescription,
                Price = productDto.ProductPrice,
                Featured = productDto.FeaturedProduct
            };
        }
        #endregion
    }
}
