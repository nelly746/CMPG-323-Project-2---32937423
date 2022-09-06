using IoT_Device_Management_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Threading.Tasks;
using Zone = IoT_Device_Management_API.Models.Zone;

namespace IoT_Device_Management_API.Services
{
    public interface IZoneService
    {
        public List<Zone> GetZones();

        public Zone getZoneByID(Guid id);

        public void createZone(Zone a);

        public void updateZone(Zone a);

        public void deleteZone(Zone a);

        public List<Device> getDevices(Guid zone_id); 
    }
}
