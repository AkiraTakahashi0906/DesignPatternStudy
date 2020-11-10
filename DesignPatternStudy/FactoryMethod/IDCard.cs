using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternStudy.FactoryMethod
{
    public class IDCard : Product
    {
        private string _owner;
        internal IDCard(string owner)
        {
            Console.WriteLine(owner + "のカードを作ります");
            _owner = owner;
        }
        public override void use()
        {
            Console.WriteLine(_owner + "のカードを使います");
        }

        public string getOwner()
        {
            return _owner;
        }

    }
}
