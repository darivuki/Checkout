﻿using Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Products
{
    public class Product : IEntity
    {
        public string Name { get; set; }

        public decimal Price { get; set; }

        public Guid Id { get; set; }
    }
}
