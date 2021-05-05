using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternStudy.Prototype
{
    namespace Framework
    {
        public class Manager
        {
            private Dictionary<string, Product> showcase = new Dictionary<string, Product>();

            public void Register(string name, Product proto)
            {
                showcase.Add(name, proto);
            }

            public Product Create(string protoName)
            {
                Product p = showcase[protoName];
                return p.CreateClone();
            }
            //fsafafasf
        }
    }

}
