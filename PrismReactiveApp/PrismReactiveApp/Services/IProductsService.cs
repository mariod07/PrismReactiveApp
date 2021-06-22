using PrismReactiveApp.Bussines;
using System;
using System.Collections.Generic;

namespace PrismReactiveApp.Services
{
    public interface IProductsService
    {
        IEnumerable<Product> GetAllProducts();
    }

    public class StaticProductsService : IProductsService
    {
        private static List<Product> _samples = new List<Product>()
        {
            new Product{Name = "reloj",Description = "de bolsillo" },
            new Product{Name = "tablero", Description = "rotring"},
            new Product{Name = "crema",Description = "crema de manos"},
            //new Product{Name = "bloqueador",Description = "solar 50v"},
            //new Product{Name = "desodorante", Description = "hombre sin macnha"},
            //new Product{Name = "cuaderno",Description = "a cuadros 100h" },
            //new Product{Name = "manzana", Description = "verde"},
            //new Product{Name = "esfero",Description = "azul fino"},
            //new Product{Name = "lapiz",Description = "2b"  },
            //new Product{Name = "cama",Description = "2 plazas"},
            //new Product{Name = "reloj", Description = "de mano"},
            //new Product{Name = "crema",Description = "de cuerpo" },
            //new Product{Name = "laptop", Description = "500gb" },
            //new Product{Name = "escritorio", Description = "grande"  },
            //new Product{Name = "silla",Description = "de mesa" },
            //new Product{Name = "mesa", Description = "6 espacios"},
            //new Product{Name = "cadena",Description = "de oro"},
            //new Product{Name = "libro",Description = "de mate"},
        };

        public IEnumerable<Product> GetAllProducts()
        {
            return _samples;
        }
    }
}