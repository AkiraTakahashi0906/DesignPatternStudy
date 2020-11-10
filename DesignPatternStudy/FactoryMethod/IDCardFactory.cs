using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternStudy.FactoryMethod
{
    public class IDCardFactory : Factory
    {
        private List<string> _owners { get; set; } = new List<string>();

        protected override Product createProduct(string owner)
        {
            return new IDCard(owner);
        }

        protected override void registerProduct(Product product)
        {
            _owners.Add(((IDCard)product).getOwner());
        }

        public List<string> getOwners()
        {
            return _owners;
        }
    }
}
