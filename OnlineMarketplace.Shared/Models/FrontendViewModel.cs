using OnlineMarketplace.Shared.Models;
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
        #region 【熱門分類附帶關聯的所有商品】
        public class FeaturedCategoryBundleDto
        {
            public int FeaturedCategoryId { get; set; } // 熱門分類的主鍵
            public string FeaturedCategoryName { get; set; } // 熱門分類的名稱
            public string FeaturedCategoryImageUrl { get; set; } // 熱門分類的圖片地址
            public string FeaturedCategoryDescription { get; set; } // 熱門分類的敘述
            public List<ProductDTO.Product> RelatedProducts { get; set; } // 熱門分類附帶的商品集合
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
