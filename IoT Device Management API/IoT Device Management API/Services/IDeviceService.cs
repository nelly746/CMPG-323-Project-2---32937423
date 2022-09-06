using IoT_Device_Management_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IoT_Device_Management_API.Services
{
    public interface IDeviceService
    {
        public List<Device> GetDevices();
        public Device GetDeviceByID(Guid id);
        public void addDevice(Device a);
        public Boolean updateDevice(Device a);
        public void deleteDevice(Device a);
    }
}
