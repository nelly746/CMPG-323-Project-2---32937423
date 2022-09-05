using IoT_Device_Management_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IoT_Device_Management_API.Services.Implementations
{
    public class DeviceService : IDeviceService
    {
        private IoT_Device_Management_SystemContext dbContext;

        public DeviceService(IoT_Device_Management_SystemContext a)
        {
            dbContext = a;
        }
        public void addDevice(Device a)
        {
            Device create = new Device();
            create.DeviceId = Guid.NewGuid();
            create.DeviceName = a.DeviceName;
            create.DateCreated = new DateTime();
            create.Status = a.Status;

            dbContext.Devices.Add(a);
            throw new NotImplementedException();
        }

        public void deleteDevice(Device a)
        {
            dbContext.Devices.Remove(a);
            throw new NotImplementedException();
        }

        public Device GetDeviceByID(Guid id)
        {
            Device toReturn = dbContext.Devices.Where(x=>x.DeviceId == id).FirstOrDefault();
            return toReturn;
        }

        public List<Device> GetDevices()
        {
            return dbContext.Devices.ToList();
        }

        public bool updateDevice(Device a)
        {
            throw new NotImplementedException();
        }
    }
}
