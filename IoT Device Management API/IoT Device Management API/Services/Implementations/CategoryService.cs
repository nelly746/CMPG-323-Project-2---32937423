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
        public void addDevice(Category a)
        {
            dbContext.Categories.Add(a);
            throw new NotImplementedException();
        }

        public void deleteCategory(Category a)
        {
            throw new NotImplementedException();
        }

        public List<Category> GetCategories()
        {
            return dbContext.Categories.ToList();
            throw new NotImplementedException();
        }

        public Category GetCategoryByID(Guid id)
        {
            return dbContext.Categories.Where(a => a.CategoryId == id).First();
            throw new NotImplementedException();
        }

        public List<Device> getDevices(Guid category_id)
        {
            //return dbContext.Categories.ToList();
            throw new NotImplementedException();
        }

        public int getZones(Guid category_id)
        {
            throw new NotImplementedException();
        }

        public bool updateCategory(Category a)
        {
            throw new NotImplementedException();
        }
    }
}
