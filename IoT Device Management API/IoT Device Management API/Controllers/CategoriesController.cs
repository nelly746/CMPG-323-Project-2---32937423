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
    public class CategoriesController : Controller
    {
        private ICategoryService cs;
        public CategoriesController(ICategoryService a)
        {
            cs = a;
        }

        [HttpGet("all")]
        public IActionResult getCategories()
        {
            return Ok(cs.GetCategories());
        }


        [HttpGet("{id}")]
        public IActionResult GetCategoryByID(Guid id)
        {
            return Ok(cs.GetCategoryByID(id));
        }

        [HttpPost("add")]
        public IActionResult addDevice(Category a)
        {
            cs.addCategory(a);
            return Ok("Category added successfully");
        }

        [HttpPatch("update")]
        public IActionResult updateCategory(Category a)
        {
            if (cs.updateCategory(a))
            {
                return Ok("category updated");
            }
            return NotFound("Category id not found");
        }

        [HttpDelete("delete")]
        public IActionResult deleteCategory(Category a)
        {
            cs.deleteCategory(a);
            return Ok("Category deleted");
        }

        [HttpGet("/devices/{category_id}")]
        public IActionResult getDevices(Guid category_id)
        {
            return Ok(cs.getDevices(category_id));
        }

        [HttpGet("/zones/{category_id}")]
        public IActionResult getZones(Guid category_id)
        {
            return Ok(cs.getZones(category_id));
        }
    }
}
