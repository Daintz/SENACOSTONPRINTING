﻿using System;
using System.Collections.Generic;

namespace DataCape
{
    public  class WarehouseModel
    {
        public WarehouseModel()
        {
            Supplies = new HashSet<SupplyModel>();
        }

        public long Id { get; set; }
        public long? WarehouseTypeId { get; set; }
        public string Name { get; set; } = null!;
        public string? Ubication { get; set; }
        public bool? StatedAt { get; set; }

        public virtual WarehouseTypeModel? WarehouseType { get; set; }
        public virtual ICollection<SupplyModel> Supplies { get; set; }
    }
}