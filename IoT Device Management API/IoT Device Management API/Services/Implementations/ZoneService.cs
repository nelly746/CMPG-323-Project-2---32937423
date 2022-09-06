using IoT_Device_Management_API.Models;
using Microsoft.EntityFrameworkCore;
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
            dbContext.Zones.Add(a);
        }

        public void deleteZone(Zone a)
        {
            if (CheckZones(a.ZoneId))
            {
                dbContext.Zones.Remove(a);
            }
            else
            {
                throw new KeyNotFoundException();
            }
        }

        public List<Device> getDevices(Guid zone_id)
        {
            List<Device> allDevices = new List<Device>();
            allDevices = dbContext.Devices.Where(a=> a.ZoneId == zone_id).ToList();
            return allDevices;
        }

        public Zone getZoneByID(Guid id)
        {
            return dbContext.Zones.Where(a=>a.ZoneId == id).FirstOrDefault();
        }

        public List<Zone> GetZones()
        {
            List<Zone> zones = dbContext.Zones.ToList();
            return zones;
        }

        public void updateZone(Zone a)
        {
            if (CheckZones(a.ZoneId))
            {
                Zone update = new Zone();
                update.ZoneId = a.ZoneId;
                update.ZoneName = a.ZoneName;
                update.ZoneDescription = a.ZoneDescription;
                update.DateCreated = a.DateCreated;
                dbContext.Zones.Update(update);
            }
            else {
                throw new KeyNotFoundException();
            }
            
        }

        private Boolean CheckZones(Guid id)
        {
            bool checker = false;
            if (dbContext.Zones.FromSqlRaw("Select * from Zones where ZoneId='" + id + "'").Count() == 1) {
                checker = true;
            }
            return checker;
        }
    }
}
