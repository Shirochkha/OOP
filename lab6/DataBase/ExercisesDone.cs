using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase
{
    public class ExercisesDone
    {
        public enum ExercisesTypes { Squat, PushUp, Plank };
        public struct DayDone
        {
            public int day;
            public int month;
            public int year;
            public int sqNum;
            public int puNum;
            public int plNum;
            public DayDone(int day, int month, int year, int sqNum, int puNum, int plNum)
            {
                this.day = day;
                this.month = month;
                this.year = year;
                this.sqNum = sqNum;
                this.puNum = puNum;
                this.plNum = plNum;
            }
        }

        public DayDone[] exercises;
        public int number;
        public DayDone this[int index]
        {
            get { return exercises[index]; }
            set { exercises[index] = value; }
        }
        public ExercisesDone(string txt)
        {
            string[] str = txt.Split(new String[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
            number = str.Length;
            exercises = new DayDone[number];
            for (int i = 0; i < number; i++)
            {
                while (str[i].Contains("  "))
                    str[i] = str[i].Replace("  ", " ");
                string date = str[i].Substring(0, str[i].IndexOf(' '));
                str[i] = str[i].Remove(0, str[i].IndexOf(' ') + 1);
                string[] DayMonYear = date.Split('.');
                string[] SqPuPl = str[i].Split(' ');
                exercises[i] = new DayDone(Convert.ToInt32(DayMonYear[0]), Convert.ToInt32(DayMonYear[1]), Convert.ToInt32(DayMonYear[2]), Convert.ToInt32(SqPuPl[0]), Convert.ToInt32(SqPuPl[1]), Convert.ToInt32(SqPuPl[2]));
            }
        }
    }
}
