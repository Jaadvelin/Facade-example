using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade_design_pattern
{
    public class Facade
    {
        protected Interface1 _Interface1;
        protected Interface2 _Interface2;

        public Facade(Interface1 Interface1, Interface2 Interface2)
        {
            this._Interface1 = Interface1;
            this._Interface2 = Interface2;
        }

        public string Operation()
        {
            string x = "Facade initializes interfaces:\n";
            x += this._Interface1.operation1();
            x += this._Interface2.operation1();
            x += "Facade calls interfaces:\n";
            x += this._Interface1.operation2();
            x += this._Interface2.operation3();

            return x;
        }
    }
}
