﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessCape.DTOs.GrammageCaliber
{
    public class GrammageCaliberUpdateDto
    {
        public long Id { get; set; } 
        public string Type { get; set; } = null!;
        public string? Name { get; set; }
    }
}
