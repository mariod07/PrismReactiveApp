using System;
using System.Collections.Generic;
using System.Text;

namespace PrismReactiveApp.Bussines
{
    public class Category
    {
        public string Name { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}
