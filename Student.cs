using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba3_2._0
{
    public class Student : Person
    {
        public int coststud { get; set; }
        public string status { get; set; }
        public int workexp { get; set; }
        public Student()
        {
        }
        public Student(List<String> studentInfo)
            : base(studentInfo)
        {
            coststud = Convert.ToInt32(studentInfo[4]);
            status = studentInfo[5];
            workexp = Convert.ToInt32(studentInfo[6]);
        }

        override public string ToString()
        {
            string s = $"{this.type},{this.name},{this.age},{this.gender},{this.coststud},{this.status},{this.workexp}";
            return s;
        }
    }
}
