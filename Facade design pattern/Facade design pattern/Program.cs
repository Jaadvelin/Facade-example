using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade_design_pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //constructors
            Interface1 Interface1 = new Interface1();
            Interface2 Interface2 = new Interface2();
            Facade facade = new Facade(Interface1, Interface2);

            Client.ClientCode(facade); //uses facade

            Console.ReadLine(); //prevents console from closing
        }
    }
}