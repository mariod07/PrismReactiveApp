using PrismReactiveApp.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace PrismReactiveApp
{
    public class AppBootstrapper
    {
        public AppBootstrapper()
        {
            RegisterService();
        }

        private void RegisterService()
        {
            Splat.Locator.CurrentMutable.Register(() => new StaticProductsService(), typeof(IProductsService));
            Splat.Locator.CurrentMutable.Register(() => new StaticCategoriesService(), typeof(ICategoryService));
        }
    }
}
