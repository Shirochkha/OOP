using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace People
{
    public class Working: Human
    {
        public Working(string lastName, int yearBirthday, string status, string job, double[] salary)
        {
            this.lastName = lastName;
            this.yearBirthday = yearBirthday;
            this.status = status;
            this.job = job;
            this.salary = salary;
        }

        public string job;
        //protected string position;
        public double[] salary = new double[5];
        public override double Info()
        {
            double max = 0;
            for (int i = 0; i < 5; i++)
            {
                if (salary[i] > max)
                {
                    max = salary[i];
                }
            }
            return max;
        }
    }
}
