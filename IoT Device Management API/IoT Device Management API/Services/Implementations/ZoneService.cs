using IoT_Device_Management_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IoT_Device_Management_API.Services.Implementations
{
    public class ZoneService : IZoneService
    {
        private IoT_Device_Management_SystemContext dbContext;

        public ZoneService(IoT_Device_Management_SystemContext a)
        {
            this.dbContext = a;
        }
        public void createZone(Zone a)
        {
            dbContext.Add(a);
            dbContext.SaveChanges();
            //throw new NotImplementedException();
        }

        public void deleteZone(Zone a)
        {
            dbContext.Zones.Remove(a);
            //throw new NotImplementedException();
        }

        public List<Device> getDevices(Guid zone_id)
        {
            List<Zone> allDevices = new List<Zone>();
            //allDevices = dbContext.Zones.Where.ToList();
           // return allDevices;
        }

        public Zone getZoneByID(Guid id)
        {
            return dbContext.Zones.Find(id);
        }

        public List<Zone> GetZones()
        {
            throw new NotImplementedException();
        }

        public void updateZone(Zone a)
        {
            throw new NotImplementedException();
        }

        private Boolean CheckZones(Guid id)
        {
            bool checker = false;
            checker =
            return
        }
    }
}
