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
            create.IsActvie = false;

            dbContext.Devices.Add(a);
        }

        public void deleteDevice(Device a)
        {
            if (checkDevice(a.DeviceId))
            {
                dbContext.Devices.Remove(a);
            }
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
            if (checkDevice(a.DeviceId))
            {
                Device b = new Device();
                b.DeviceId = a.DeviceId;
                b.DeviceName = a.DeviceName;
                b.CategoryId = a.CategoryId;
                b.DateCreated = a.DateCreated;
                b.IsActvie = a.IsActvie;
                b.Status = a.Status;
                b.ZoneId = a.ZoneId;
                dbContext.Devices.Update(b);
                return true;
            }
            return false;
        }

        private Boolean checkDevice(Guid id) {
            bool checker = false;
            if (dbContext.Devices.Where(a => a.DeviceId == id).Count() == 1) {
                checker = true;
            }
            return true;
        }
    }
}
