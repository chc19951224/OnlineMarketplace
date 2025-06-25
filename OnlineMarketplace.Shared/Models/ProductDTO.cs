using OnlineMarketplace.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineMarketplace.Shared.Models
{
    public class ProductDTO
    {
        #region 【 商品 數據傳輸對象 】
        public class Product
        {
            public int RelatedCategoryId { get; set; } // 商品歸類的主鍵
            public CategoryDTO.Category RelatedCategory { get; set; } // 商品歸類的名稱

            public int ProductId { get; set; } // 商品的主鍵
            public string ProductName { get; set; } // 商品的名稱
            public string ProductImageUrl { get; set; } // 商品的圖片地址
            public string ProductDescription { get; set; } // 商品的敘述
            public decimal ProductPrice { get; set; } // 商品的價格
            public bool FeaturedProduct { get; set; } // 熱門的商品
        }
        #endregion
    }
}
