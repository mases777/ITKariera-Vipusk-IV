﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CRUDWithoutORM.Common
{
    public class Product
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }

        public int Stock { get; set; }
        public Product()
        {

        }

        public Product(int id, string name, decimal price, int stock)
        {
            this.Id = id;
            this.Name = name;
            this.Price = price;
            this.Stock = stock;
        }
    }
}
