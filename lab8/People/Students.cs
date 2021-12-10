using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace People
{
    public class Students : Pupils
    {
        public Students(string lastName, int yearBirthday, string status, string nameStudyBuilding, 
            string group, int[] marks)
        {
            this.lastName = lastName;
            this.yearBirthday = yearBirthday;
            this.status = status;
            this.nameStudyBuilding = nameStudyBuilding;
            this.group = group;
            this.marks = marks;
        }

        public string group;
        override public string InfoHuman(string group)
        {
            return lastName + " " + nameStudyBuilding + " " + group + " " + status + " " + yearBirthday + " " + Info();
        }
    }
}
