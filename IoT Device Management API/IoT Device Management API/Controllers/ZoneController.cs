using IoT_Device_Management_API.Models;
using IoT_Device_Management_API.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IoT_Device_Management_API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ZoneController : Controller
    {
        private IZoneService zs;
        
        public ZoneController(IZoneService a)
        {
            this.zs = a;
        }

        [HttpGet]
        [Route("all")]
        public IActionResult getZones()
        {
            return (IActionResult)zs.GetZones();
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult getZoneByID(Guid id)
        {
            return Ok(zs.getZoneByID(id));
        }


        [HttpPost]
        [Route("add")]
        public IActionResult createZone(Zone a)
        {
            zs.createZone(a);
            return Ok("Zone created successfully");
        }

        [HttpPatch]
        [Route("update")]
        public IActionResult updateZone(Zone a)
        {
            zs.updateZone(a);
            return Ok("Zone updated successfully");
        }

        [HttpDelete]
        [Route("delete")]
        public IActionResult deleteZone(Zone a)
        {
            zs.deleteZone(a);
            return Ok("Zone deleted");
        }

        [HttpGet]
        [Route("devices/{zone_id}")]
        public IActionResult getDevices(Guid zone_id)
        {
            return (IActionResult)zs.getDevices(zone_id);
        }
    }
}
