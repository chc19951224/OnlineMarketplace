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
    public static class ProductMapper
    {
        #region 【 商 品 】
        // 實體對象 ===> 數據傳輸對象 
        public static readonly Expression<Func<Product, ProductDTO.Product>> EntityToProductDto =
            entity => new ProductDTO.Product
            {
                RelatedCategoryId = entity.CategoryId,
                RelatedCategory = new CategoryDTO.Category
                {
                    CategoryId = entity.CategoryId,
                    CategoryName = entity.Name,
                    CategoryImageUrl = entity.ImageUrl,
                    CategoryDescription = entity.Description,
                    FeaturedCategory = entity.Featured
                },
                ProductId = entity.Id,
                ProductName = entity.Name,
                ProductImageUrl = entity.ImageUrl,
                ProductDescription = entity.Description,
                ProductPrice = entity.Price,
                FeaturedProduct = entity.Featured
            };

        // 數據傳輸對象 ===> 實體對象
        public static Product ProductDtoToEntity(ProductDTO.Product dto)
        {
            return new Product
            {
                CategoryId = dto.RelatedCategoryId,
                Category = CategoryMapper.CategoryDtoToEntity(dto.RelatedCategory),
                Id = dto.ProductId,
                Name = dto.ProductName,
                ImageUrl = dto.ProductImageUrl,
                Description = dto.ProductDescription,
                Price = dto.ProductPrice,
                Featured = dto.FeaturedProduct
            };
        }
        #endregion
    }
}
