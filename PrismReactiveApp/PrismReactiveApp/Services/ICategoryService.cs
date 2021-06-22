using PrismReactiveApp.Bussines;
using System;
using System.Collections.Generic;

namespace PrismReactiveApp.Services
{
    public interface ICategoryService
    {
        IEnumerable<Category> GetAllCategories();
    }

    public class StaticCategoriesService : ICategoryService
    {
        private static List<Category> _samplesCategories = new List<Category>()
        {
            new Category {Name = "Casa", 
            Products = new List<Product>()
            {
                new Product{Name = "reloj",Description = "de bolsillo" },
                new Product{Name = "tablero", Description = "rotring"},
                new Product{Name = "crema",Description = "crema de manos"},
                new Product{Name = "bloqueador",Description = "solar 50v"},
            } },

            new Category {Name = "Cocina",
            Products = new List<Product>()
            {
                new Product{Name = "desodorante", Description = "hombre sin macnha"},
                new Product{Name = "cuaderno",Description = "a cuadros 100h" },
                new Product{Name = "manzana", Description = "verde"},
                new Product{Name = "esfero",Description = "azul fino"},
            } },

        };

        public IEnumerable<Category> GetAllCategories()
        {
            return _samplesCategories;
        }
    }
}