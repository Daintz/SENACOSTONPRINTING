﻿using System;
using System.Collections.Generic;

namespace DataCape
{
    public class GrammageCaliberXQuotationClientDetailModel
    {
        public long? OrderProductionId { get; set; }
        public long? GrammageCaliberId { get; set; }

        public virtual GrammageCaliberModel? GrammageCaliber { get; set; }
        public virtual QuotationClientDetailModel? OrderProduction { get; set; }
    }
}
