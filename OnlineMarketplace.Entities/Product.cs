using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineMarketplace.Entities
{
    public class Product : BaseEntity
    {
        public int CategoryId { get; set; } // 商品的歸類外鍵
        public Category Category { get; set; } // 商品的歸類，表示多對一的關係
        public decimal Price { get; set; } // 商品的價格
    }
}
