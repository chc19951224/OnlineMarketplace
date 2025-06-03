using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineMarketplace.Entities
{
    public class BaseEntity
    {
        public int Id { get; set; } // 主鍵
        public string Name { get; set; } // 名稱
        public string ImageUrl { get; set; } // 圖片地址
        public string Description { get; set; } // 敘述
        public bool Featured { get; set; } // 熱門
    }
}
