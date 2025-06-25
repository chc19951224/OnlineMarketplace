using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineMarketplace.Shared.Models
{
    public class BackendViewModel
    {
        #region 【 數 據 傳 輸 對 象 】
        #region 【面板數據對象】
        public class PanelDto
        {
            public int TotalCategories { get; set; } // 分類的總數
            public int TotalProducts { get; set; } // 商品的總數
        }
        #endregion
        #endregion

        #region 【 視 圖 模 型 】
        public class IndexViewModel
        {
            public PanelDto Panel { get; set; }
        }
        #endregion
    }
}
