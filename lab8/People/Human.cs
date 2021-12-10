using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace People
{
    public abstract class Human
    {
        public string lastName;
        public int yearBirthday;
        public string status;
        public abstract double Info();

        public string InfoHuman()
        {
            return lastName + " " + yearBirthday + " " + status + " " + Info();
        }

        public virtual string InfoHuman(int a)
        {
            return lastName + " " + yearBirthday + " " + status + " " + Info();
        }

        public virtual string InfoHuman(string a)
        {
            return lastName + " " + yearBirthday + " " + status + " " + Info();
        }
    }
}
