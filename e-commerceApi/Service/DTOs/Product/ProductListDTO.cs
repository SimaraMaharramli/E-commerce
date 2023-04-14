﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.DTOs.Product
{
    public class ProductListDTO
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public decimal Price { get; set; }
        public int Count { get; set; }
        public byte[] Image { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
