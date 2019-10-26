using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade_design_pattern
{
    public class Interface1
    {
        public string operation1()
        {
            return "Interface1: Initialized\n";
        }

        public string operation2()
        {
            return "Interface1: Called by facade\n";
        }
    }
}
