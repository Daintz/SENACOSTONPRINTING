﻿using DataCape.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessCape.DTOs.WarehauseType
{
    public class WarehauseTypeCreateDto
    {
        public long IdTypeWarehouse { get; set; }
        public bool? StatedAt { get; set; }
        public string? Nametype { get; set; } = null!;
        public string? Description { get; set; }

        

    }
}
