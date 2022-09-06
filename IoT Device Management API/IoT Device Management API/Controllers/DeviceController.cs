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
    public class DeviceController : Controller
    {
        private IDeviceService ds;

        public DeviceController(IDeviceService a)
        {
            ds = a;
        }

        [HttpGet]
        [Route("all")]
        public IActionResult devices()
        {
            return Ok((IActionResult)ds.GetDevices());
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult getDeviceByID(Guid id) {
            return (IActionResult)ds.GetDeviceByID(id);
        }

        [HttpPost]
        [Route("add")]
        public IActionResult addDevices(Device a)
        {
            ds.addDevice(a);
            return Ok("Device created successfully");
        }

        [HttpPatch]
        [Route("update")]
        public IActionResult updateDevice(Device a)
        {
            if (ds.updateDevice(a))
            {
                return Ok("Device Updates successfully");
            }
            return NotFound("Id not found");
        }

        [HttpDelete]
        [Route("delete")]
        public IActionResult deleteDevice(Device a)
        {
            ds.deleteDevice(a);
            return Ok("Device deleted");
        }
    }
}
