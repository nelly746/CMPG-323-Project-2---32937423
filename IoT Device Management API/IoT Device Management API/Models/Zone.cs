using System;
using System.Collections.Generic;

#nullable disable

namespace IoT_Device_Management_API.Models
{
    public partial class Zone
    {
        public Guid ZoneId { get; set; }
        public string ZoneName { get; set; }
        public string ZoneDescription { get; set; }
        public DateTime DateCreated { get; set; }
    }
}
