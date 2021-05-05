using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternStudy.head_first_Observer
{
    public interface Observer
    {
        void Update(float temp, float humidity, float pressure);
    }
}
