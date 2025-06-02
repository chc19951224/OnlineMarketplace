using OnlineMarketplace.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineMarketplace.DataAccess
{
    public class MarketplaceDbContext : DbContext, IDisposable
    {
        public MarketplaceDbContext() : base("name=MarketplaceConnection")
        {

        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
