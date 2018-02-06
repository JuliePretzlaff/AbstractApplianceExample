using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractApplianceExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Microwave microOne = new Microwave(1000, "Samsung");

            Dishwasher washerOne = new Dishwasher(0, true);

            microOne.Work();
            washerOne.Work();
        }
    }
}
