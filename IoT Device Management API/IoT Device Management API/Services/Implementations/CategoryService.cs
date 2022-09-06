using IoT_Device_Management_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IoT_Device_Management_API.Services.Implementations
{
    public class CategoryService : ICategoryService
    {
        private IoT_Device_Management_SystemContext dbContext;
        public CategoryService(IoT_Device_Management_SystemContext a)
        {
            dbContext = a;
        }
        public void addCategory(Category a)
        {
            dbContext.Categories.Add(a);
 
        }

        public void deleteCategory(Category a)
        {
            if (checkCategory(a.CategoryId))
            {
                dbContext.Categories.Remove(a);
            }
            else {
                throw new KeyNotFoundException();
            }
        }

        public List<Category> GetCategories()
        {
            return dbContext.Categories.ToList();

        }

        public Category GetCategoryByID(Guid id)
        {
            if (checkCategory(id))
            {
                return dbContext.Categories.Where(a => a.CategoryId == id).First();
            }
            return null;
        }

        public List<Device> getDevices(Guid category_id)
        {
            return dbContext.Devices.Where(a=>a.CategoryId == category_id).ToList();
        }

        public int getZones(Guid category_id)
        {
            return dbContext.Devices.Where(a=>a.CategoryId == category_id).Count();
        }

        public bool updateCategory(Category a)
        {
            if (checkCategory(a.CategoryId))
            {
                Category newCat = new Category();
                newCat.CategoryId = a.CategoryId;
                newCat.CategoryName = a.CategoryName;
                newCat.CategoryDescription = a.CategoryDescription;
                newCat.DateCreated = a.DateCreated;
                dbContext.Categories.Update(a);
                return true;
            }
            return false;
        }

        private Boolean checkCategory(Guid id) {
            bool checker = false;
            if (dbContext.Categories.Where(a => a.CategoryId == id).Count() == 1) {
                checker = true;
            }
            return checker;
        }
    }
}
