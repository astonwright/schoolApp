using System;
using System.Collections.Generic;
using System.Text;

namespace schoolLibrary
{
    public class car : vehicle
    {
        public string make { get; set; }
        public string model { get; set; }
        public string type { get; set; }
        public string year { get; set; }
        public int numberOfDoors { get; set; }


        public car() 
        {
            make = "";
            model = "";
            type = "";
        }

        public static int countCarDoor(int a) //Method syntax
        {
            var result = a;
            return result;
        }

    }

    }

}
