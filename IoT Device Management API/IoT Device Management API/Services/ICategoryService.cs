using IoT_Device_Management_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IoT_Device_Management_API.Services
{
    public interface ICategoryService
    {
        public List<Category> GetCategories();
        public Category GetCategoryByID(Guid id);
        public void addCategory(Category a);
        public Boolean updateCategory(Category a);
        public void deleteCategory(Category a);

        public List<Device> getDevices(Guid category_id);

        public int getZones(Guid category_id);
    }
}
