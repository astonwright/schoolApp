using System;
using System.Collections.Generic;
using System.Text;

namespace schoolLibrary
{
    public class student : person
    {
        public enum gradeLevels { freshman, sophomore, junor, senior }
        public gradeLevels gradeLevel { get; set; }
    }
}
