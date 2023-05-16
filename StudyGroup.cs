using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba3_2._0
{
    public class StudyGroup
    {
        public string type { get; set; }
        public string GroupName { get; set; }
        public int amountOfPeople { get; set; }


        public StudyGroup()
        {
        }

        public StudyGroup(List<string> wgInfo)
        {
            type = wgInfo[0];
            GroupName = wgInfo[1];
            amountOfPeople = Convert.ToInt32(wgInfo[2]);
        }

        override public string ToString()
        {
            string s = $"{this.type},{this.GroupName},{this.amountOfPeople}";
            return s;
        }
    }
}
