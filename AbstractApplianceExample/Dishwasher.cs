using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractApplianceExample
{
    public class Dishwasher : Appliance
    {
        //fields:
        //invisible

        //properties:
        public double DecibelLevel { get; set; }
        public bool HasHeatDry { get; set;}


        //constructors:
        public Dishwasher()
        {
            //default constructor
        }

        public Dishwasher(double DecibelLeveL, bool HasHeatDry)
        {
            this.DecibelLevel = DecibelLeveL;
            this.HasHeatDry = HasHeatDry;

        }

        //methods:
        public override void Work()
        {
            Console.WriteLine("I wash your dishes.");
            Console.WriteLine("wash wash wash wash wash wash wash wash");
        }

    }
}
