using System;
using System.Collections.Generic;
using System.Text;

namespace schoolLibrary
{
    public class bike : vehicle
    {
        public string make { get; set; }
        public string model { get; set; }
        public string type { get; set; }
        public string year { get; set; }
        public int numberOfGears { get; set; }
        public enum gears { fisrt, second, third, fourth, fifth, sixth }

        public gears whichGear { get; set; }

        public  bike()
        {
            make = "";
            model = "";
            type = "";
        }

        public static int startBikeInGear(int a) //Method syntax
        {
            var result = a;
            return result;
        }

    }
}
