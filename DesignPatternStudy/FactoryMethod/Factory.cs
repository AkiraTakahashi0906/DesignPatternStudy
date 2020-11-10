using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternStudy.FactoryMethod
{
    public abstract class Factory
    {
        public Product create(string owner)
        {
            Product p = createProduct(owner);
            registerProduct(p);
            return p;
        }
        protected abstract Product createProduct(string owner);
        protected abstract void registerProduct(Product product);
    }
}
