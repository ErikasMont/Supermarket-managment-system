using CoreBusiness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UseCases.DataStorePluginInterfaces
{
    public abstract class IProductRepository
    {
        public abstract IEnumerable<Product> GetProducts();
    }
}
