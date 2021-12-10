using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace People
{
    interface IComparable
    {
    }
    public class Pupils: Human, IComparable
    {
        public string nameStudyBuilding;
        public int[] marks;
        public override double Info()
        {
            double sum = 0;
            for(int i=0; i<marks.Length; i++)
            {
                sum += marks[i];
            }
            return Math.Round(sum / marks.Length, 2);
        }

    }
}
