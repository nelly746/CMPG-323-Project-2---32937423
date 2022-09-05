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
            List<Device> allDevices = new List<Device>();
            //allDevices = dbContext.Zones.Where.ToList();
            return allDevices;
        }

        public Zone getZoneByID(Guid id)
        {
            return dbContext.Zones.Find(id);
        }

        public List<Zone> GetZones()
        {
            List<Zone> zones = dbContext.Zones.ToList();
            throw new NotImplementedException();
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
