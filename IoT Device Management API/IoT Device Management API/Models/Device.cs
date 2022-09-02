﻿using System;
using System.Collections.Generic;

#nullable disable

namespace IoT_Device_Management_API.Models
{
    public partial class Device
    {
        public Guid DeviceId { get; set; }
        public string DeviceName { get; set; }
        public Guid CategoryId { get; set; }
        public Guid ZoneId { get; set; }
        public string Status { get; set; }
        public bool IsActvie { get; set; }
        public DateTime DateCreated { get; set; }
    }
}
