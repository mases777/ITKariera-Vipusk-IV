using CRUDWithoutORM.Common;
using CRUDWithoutORM.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace CRUDWithoutORM.Business
{
    public class ProductBusiness
    {
        private ProductData manager = new ProductData();

        public List<Product> GetAll() => manager.GetAll();

        public Product Get(int id) => manager.Get(id);

        public void Add(Product product) => manager.Add(product);

        public void Update(Product product) => manager.Update(product);

        public bool Delete(int id) => manager.Delete(id);
    }
}
