using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace People
{
    public class Schoolchildren: Pupils
    {
        public Schoolchildren(string lastName, int yearBirthday, string status, string nameStudyBuilding,
            int room, int[] marks)
        {
            this.lastName = lastName;
            this.yearBirthday = yearBirthday;
            this.status = status;
            this.nameStudyBuilding = nameStudyBuilding;
            this.room = room;
            this.marks = marks;
        }

        public int room;
        override public string InfoHuman(int room)
        {
            return lastName + " " + nameStudyBuilding + " " + room + " " + status + " " + yearBirthday + " " + Info();
        }
    }
}
