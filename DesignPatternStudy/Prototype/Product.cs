using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternStudy.Prototype
{
    namespace Framework
    {
        public interface Product :ICloneable
        {
            void use(string s);
            Product CreateClone();
        }
    }
}
