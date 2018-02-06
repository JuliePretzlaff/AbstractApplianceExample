using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractApplianceExample
{
    public class Microwave : Appliance //microwave is red until we use the work method from the base abstract class
    {
        //fields:
        private int watts;
        private string brand;


        //properties
        public int Watts { get; set; }
        public string Brand { get; set; }


        //constructors
        public Microwave(int watts, string brand)
        {
            this.watts = watts;
            this.brand = brand;
        }

        //methods
        public override void Work()
        {
            Console.WriteLine("I emit radioactive waves.");
            Console.WriteLine("I heat up  your food.");
        }
    }
}

