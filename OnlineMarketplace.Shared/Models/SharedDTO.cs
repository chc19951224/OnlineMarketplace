using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineMarketplace.Shared.Models
{
    public class SharedDTO
    {
        #region 【 分頁 數據傳輸對象 】
        public class PageRequestDTO
        {
            public int TotalRecords { get; set; }
            public int TotalPages { get; set; }
            public int PageSize { get; set; }
            public int PageNumber { get; set; }
        }
        #endregion
    }
}
