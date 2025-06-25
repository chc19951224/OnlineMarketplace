using OnlineMarketplace.Repositories;
using OnlineMarketplace.Shared.Mappers;
using OnlineMarketplace.Shared.Models;
using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineMarketplace.Services
{
    public class BackendService
    {
        #region 【 後 端 首 頁 業 務 邏 輯 】
        // BR1 獲取面板統計數據
        public BackendViewModel.PanelDto GetPanelStatistics()
        {
            using (var context = new MarketplaceDbContext())
            {
                var panel = new BackendViewModel.PanelDto
                {
                    TotalCategories = context.Categories.Count(),
                    TotalProducts = context.Products.Count()
                };
                return panel;
            }
        }
        #endregion
    }
}
