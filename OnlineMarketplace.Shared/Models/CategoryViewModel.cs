using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineMarketplace.Shared.Models
{
    public class CategoryViewModel
    {
        #region 【 後 端 視 圖 模 型 】
        #region 【 管 理 分 類 頁 】
        public class ManageCategoryViewModel
        {
            public List<CategoryDTO.Category> Categories { get; set; }
            public SharedDTO.PageRequestDTO PageRequest { get; set; }
        }
        #endregion

        #region 【 更 新 分 類 頁 】
        public class UpdateCategoryViewModel
        {
            public CategoryDTO.Category Category { get; set; }
        }
        #endregion
        #endregion
    }
}
