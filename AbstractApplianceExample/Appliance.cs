using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractApplianceExample
{
    public abstract class Appliance
    {
        //field
        private bool isElectric;


        //properties
        public bool IsElectric
        {
            get { return this.isElectric; }
            set { this.isElectric = value; }

        }

        //constructors
        public Appliance()
        {
            //default constructor, will never be used
        }

        //methods
        public abstract void Work();
            //no body in this abstract method, nor {}
    }   
}
