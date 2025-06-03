using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineMarketplace.Shared
{
    public class FrontendViewModel
    {
        #region 【 數 據 傳 輸 對 象 】
        #region 【分類對象】
        public class CategoryDto
        {
            public int CategoryId { get; set; } // 分類的主鍵
            public string CategoryName { get; set; } // 分類的名稱
            public string CategoryImageUrl { get; set; } // 分類的圖片地址
            public string CategoryDescription { get; set; } // 分類的敘述
            public bool FeaturedCategory { get; set; } // 熱門的分類
        }
        #endregion

        #region 【商品對象】
        public class ProductDto
        {
            public int RelatedCategoryId { get; set; } // 商品歸類的主鍵
            public CategoryDto RelatedCategory { get; set; } // 商品歸類的名稱

            public int ProductId { get; set; } // 商品的主鍵
            public string ProductName { get; set; } // 商品的名稱
            public string ProductImageUrl { get; set; } // 商品的圖片地址
            public string ProductDescription { get; set; } // 商品的敘述
            public decimal ProductPrice { get; set; } // 商品的價格
            public bool FeaturedProduct { get; set; } // 熱門的商品
        }
        #endregion

        #region 【熱門分類附帶關聯的所有商品】
        public class FeaturedCategoryBundleDto
        {
            public int FeaturedCategoryId { get; set; } // 熱門分類的主鍵
            public string FeaturedCategoryName { get; set; } // 熱門分類的名稱
            public string FeaturedCategoryImageUrl { get; set; } // 熱門分類的圖片地址
            public string FeaturedCategoryDescription { get; set; } // 熱門分類的敘述
            public List<ProductDto> RelatedProducts { get; set; } // 熱門分類附帶的商品集合
        }
        #endregion
        #endregion

        #region 【 視 圖 模 型 】
        #region 【前台首頁模型】
        public class IndexViewModel
        {
            public List<FeaturedCategoryBundleDto> FeaturedCategoryBlock { get; set; }
        }
        #endregion
        #endregion
    }
}
