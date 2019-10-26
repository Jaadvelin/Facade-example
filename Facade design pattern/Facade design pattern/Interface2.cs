using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade_design_pattern
{
    public class Interface2
    {
        public string operation1()
        {
            return "Interface2: Initialized\n";
        }

        public string operation3()
        {
            return "Interface2: Called by facade\n";
        }
    }
}
