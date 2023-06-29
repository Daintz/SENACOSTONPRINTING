﻿using System;
using System.Collections.Generic;

namespace DataCape.Models
{
    public class TypeServiceModel
    {
        public long Id { get; set; }
        public string Name { get; set; } = null!;
        public bool? StatedAt { get; set; }
        public decimal? Costo { get; set; }

        public virtual ICollection<QuotationClientModel> GetQuotationClients { get; set; }

    }
}
