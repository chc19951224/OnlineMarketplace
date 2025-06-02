using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineMarketplace.Entities
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public int Name { get; set; }
        public int ImageUrl { get; set; }
        public int Description { get; set; }
        public int Featured { get; set; }
    }
}
