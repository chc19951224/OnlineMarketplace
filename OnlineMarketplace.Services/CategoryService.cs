using OnlineMarketplace.Repositories;
using OnlineMarketplace.Shared;
using OnlineMarketplace.Shared.Mappers;
using OnlineMarketplace.Shared.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineMarketplace.Services
{
    public class CategoryService
    {
        #region 【 分 類 業 務 邏 輯 】
        #region 【 通 用 方 法 】
        // R1 獲取所有分類
        public List<CategoryDTO.Category> FindAllCategories()
        {
            using (var context = new MarketplaceDbContext())
            {
                var dtos = context.Categories.Select(CategoryMapper.EntityToCategoryDto).ToList();
                return dtos;
            }
        }

        // R2 獲取特定分類
        public CategoryDTO.Category FindCategoryById(int id)
        {
            using (var context = new MarketplaceDbContext())
            {
                var dto = context.Categories.Where(c => c.Id == id).Select(CategoryMapper.EntityToCategoryDto).FirstOrDefault();
                return dto;
            }
        }
        #endregion

        #region 【 前 端 】
        // 暫無
        #endregion

        #region 【 後 端 】
        // BR1 表格默認搜索
        public CategoryViewModel.ManageCategoryViewModel FindCategoryApi(int PageNumber, int pageSize)
        {
            using (var context = new MarketplaceDbContext())
            {
                var totalRecords = context.Categories.Count();
                var totalPages = (int)Math.Ceiling((double)totalRecords / pageSize);


                var offset = ((PageNumber - 1) * pageSize);

                var dtos = context.Categories
                    .Select(CategoryMapper.EntityToCategoryDto)
                    .OrderBy(dto => dto.CategoryId)
                    .Skip(offset)
                    .Take(pageSize)
                    .ToList();

                return new CategoryViewModel.ManageCategoryViewModel
                {
                    PageRequest = new SharedDTO.PageRequestDTO
                    {
                        TotalRecords = totalRecords,
                        TotalPages = totalPages,
                        PageNumber = PageNumber,
                        PageSize = pageSize
                    },
                    Categories = dtos
                };
            }
        }

        // BR1 關鍵字搜索
        //public List<CategoryDTO.Category> FindCategoryByKey(string searchValue, int pageSize, int pageNumber)
        //{
        //    using (var context = new MarketplaceDbContext())
        //    {
        //        if (String.IsNullOrEmpty(searchValue))
        //        {
        //            return new List<CategoryDTO.Category>();
        //        }
        //        else
        //        {
        //            var pageInfo = CategoryFilter(pageSize, pageNumber);
        //            var offset = ((pageInfo.PageNumber - 1) * pageInfo.PageSize);

        //            var query = context.Categories.AsQueryable();
        //            query = query.Where(c => c.Name.Contains(searchValue));
        //            query = query.Skip(offset);
        //            query = query.Take(pageInfo.PageSize);

        //            return query.ToList().Select(CategoryMapper.EntityToCategoryDto).ToList();
        //        }
        //    }
        //}

        // BR2 分頁搜索
        public SharedDTO.PageRequestDTO CategoryFilter(int pageSize, int pageNumber)
        {
            var totalRecords = FindAllCategories().Count();
            var totalPages = (int)Math.Ceiling((double)totalRecords / pageSize);

            return new SharedDTO.PageRequestDTO
            {
                TotalRecords = totalRecords,
                TotalPages = totalPages,
                PageNumber = pageNumber,
                PageSize = pageSize
            };
        }

        // BC1 新增數據庫分類
        public bool AddCategory(CategoryDTO.Category tableData)
        {
            using (var context = new MarketplaceDbContext())
            {
                var categoryEntity = CategoryMapper.CategoryDtoToEntity(tableData);
                bool isExist = context.Categories.Any(c => c.Name == categoryEntity.Name);

                if (!isExist)
                {
                    context.Categories.Add(categoryEntity);
                    context.SaveChanges();
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        // BU1 修改數據庫分類
        public bool ModifyCategory(CategoryDTO.Category tableData)
        {
            using (var context = new MarketplaceDbContext())
            {
                var cartegoryEntity = CategoryMapper.CategoryDtoToEntity(tableData);
                var isExist = context.Categories.Any(c => c.Id == tableData.CategoryId);

                if (isExist)
                {
                    context.Entry(cartegoryEntity).State = EntityState.Modified;
                    context.SaveChanges();
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        // BD1 刪除數據庫分類
        public bool RemoveCategoryById(int categoryDtoId)
        {
            using (var context = new MarketplaceDbContext())
            {
                var categoryEntity = context.Categories.Find(categoryDtoId);
                if (categoryEntity != null)
                {
                    context.Entry(categoryEntity).State = EntityState.Deleted;
                    context.SaveChanges();
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        #endregion
        #endregion
    }
}
