using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba3_2._0
{
    public class Person
    {
        public string type { get; set; }
        public string name { get; set; }
        public int age { get; set; }
        public string gender { get; set; }
        override public string ToString()
        {
            string s = $"{this.type},{this.name},{this.age},{this.gender}";
            return s;
        }

        public Person()
        {

        }
        public Person(List<String> personInfo)
        {
            type = personInfo[0];
            name = personInfo[1];
            age = Convert.ToInt32(personInfo[2]);
            gender = personInfo[3];
        }
    }
}
