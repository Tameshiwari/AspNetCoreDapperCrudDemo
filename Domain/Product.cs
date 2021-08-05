﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreDapperCrudDemo.Domain
{
    public class Product : BaseEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal? Price { get; set; }
        public int? Quantity { get; set; }
    }
}
