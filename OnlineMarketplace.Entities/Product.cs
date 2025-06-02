using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineMarketplace.Entities
{
    public class Product : BaseEntity
    {
        public int CategoryId { get; set; }
        public Category CategoryName { get; set; }
        public decimal Price { get; set; }
    }
}
