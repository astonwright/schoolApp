using System;
using System.Collections.Generic;
using System.Text;

namespace schoolLibrary
{
    public class school
    {
        
        public string name { get; set; }
        public string address { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string zip { get; set; }
        public string phoneNumber { get; set; }
        private string _twitterAddress;
        public string twitterAddress
        {
            //make sure the twitter address starts with @
            get { return _twitterAddress; }
            set 
            {
                if(value.StartsWith("@"))
                {
                    _twitterAddress = value;
                } else
                {
                    throw new Exception("The twitter address must begin with @");
                }
            }
        }

        public school() //Constructor for instanciation. No values specified hence default value given.
        {
            name = "Untitled School";
            phoneNumber = "555 - 1234";
        }

        public school(string schoolName, string schoolPhoneNumber) //Constructor for instanciation. Values have to be given which then gets assigned to properties.
        {
            name = schoolName;
            phoneNumber = schoolPhoneNumber;
        }

        //public float averageThreeScores( float a, float b, float c)
        //{
        //    var result = (a + b + c) / 3;
        //    return result;
        //}

        public  static float averageThreeScores(float a, float b, float c) => (a + b + c) / 3; //Function Bodily Expression 
        public static int averageThreeScores(int a, int b, int c) //Method syntax
        {
            var result = (a + b + c) / 3;
            return result;
        }

        public override string ToString() //Overide class method ToString
        {
            var sb = new StringBuilder();
            sb.AppendLine(name);
            sb.AppendLine(address);
            sb.Append(city);
            sb.AppendLine(",");
            sb.AppendLine(state);
            sb.AppendLine("  ");
            sb.AppendLine(zip);

            return sb.ToString();
        }

    }
}
