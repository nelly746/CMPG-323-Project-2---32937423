using IoT_Device_Management_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IoT_Device_Management_API.Services
{
    interface ICategoryService
    {
        public List<Category> GetCategories();
        public Category GetCategoryByID(Guid id);
        public void addDevice(Category a);
        public Boolean updateCategory(Category a);
        public void deleteCategory(Category a);
        private Boolean checkCategory(Guid id);

        public List<Device> getDevices(Guid category_id);

        public int getZones(Guid category_id);
    }
}
