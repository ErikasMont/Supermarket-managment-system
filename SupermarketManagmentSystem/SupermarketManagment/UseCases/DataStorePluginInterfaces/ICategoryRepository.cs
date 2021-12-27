using CoreBusiness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UseCases.DataStorePluginInterfaces
{
    public abstract class ICategoryRepository
    {
        public abstract IEnumerable<Category> GetCategories();
    }
}
