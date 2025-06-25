using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineMarketplace.Shared.Models
{
    public class CategoryDTO
    {
        #region 【 分類 數據傳輸對象 】
        public class Category
        {
            public int CategoryId { get; set; } // 分類的主鍵
            public string CategoryName { get; set; } // 分類的名稱
            public string CategoryImageUrl { get; set; } // 分類的圖片地址
            public string CategoryDescription { get; set; } // 分類的敘述
            public bool FeaturedCategory { get; set; } // 熱門的分類
        }
        #endregion
    }
}
