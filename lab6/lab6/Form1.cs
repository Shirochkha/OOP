using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataBase;
using System.IO;

namespace lab6
{
    public partial class Form1 : Form
    {
        ExercisesDone exe;
        public Form1()
        {
            InitializeComponent();
        }

        private void Output_Click(object sender, EventArgs e)
        {
            StreamReader f = new StreamReader("D:\\exe.txt");
            exe = new ExercisesDone(f.ReadToEnd());
            f.Close();
            text.Text = "";

            for (int i = 0; i < exe.number; i++)
            {
                text.Text += exe[i].day + "." + exe[i].month + "." + exe[i].year + " " + exe[i].sqNum + " " + exe[i].puNum + " " + exe[i].plNum + Environment.NewLine;
            }
            text.Enabled = true;
            edit.Enabled = true;
            zad1.Enabled = true;
            zad2.Enabled = true;
            zad3.Enabled = true;
        }

        private void edit_Click(object sender, EventArgs e)
        {
            exe = new ExercisesDone(text.Text);
            StreamWriter f = new StreamWriter("D:\\exe.txt", false);
            f.Write(text.Text);
            f.Close();
        }

        private void zad1_Click(object sender, EventArgs e)
        {
            edit.Enabled = false;
            text.Text = "";
            for (int i = 0; i < exe.number; i++)
            {
                if (exe[i].day == Convert.ToInt32(day.Text) && exe[i].month == Convert.ToInt32(month.Text) && exe[i].year == Convert.ToInt32(year.Text))
                {
                    text.Text = exe[i].day + "." + exe[i].month + "." + exe[i].year + " " + exe[i].sqNum + " " + exe[i].puNum + " " + exe[i].plNum + Environment.NewLine;
                    int dayAllTickets = exe[i].sqNum + exe[i].puNum + exe[i].plNum;
                    text.Text += "\r\nКоличество выполненных упражнений за указанный день: " + dayAllTickets;
                    break;
                }
            }
            if (text.Text == "")
                text.Text = "Такой даты нет.";
        }

        private void zad2_Click(object sender, EventArgs e)
        {
            edit.Enabled = false;
            int avrSq = 0;
            int avrPu = 0;
            int avrPl = 0;
            int start = -1;
            int finish = -1;
            text.Text = "";
            for (int i = 0; i < exe.number; i++)
            {
                if (exe[i].day == Convert.ToInt32(firstDay.Text) && exe[i].month == Convert.ToInt32(firstMonth.Text) && exe[i].year == Convert.ToInt32(firstYear.Text))
                {
                    start = i;
                    break;
                }
            }
            for (int i = 0; i < exe.number; i++)
            {
                if (exe[i].day == Convert.ToInt32(lastDay.Text) && exe[i].month == Convert.ToInt32(lastMonth.Text) && exe[i].year == Convert.ToInt32(lastYear.Text))
                {
                    finish = i;
                    break;
                }
            }
            if (start == -1 || finish == -1 || start > finish)
                text.Text = "Период введён неверно.";
            else
            {
                for (int i = start; i <= finish; i++)
                {
                    text.Text += exe[i].day + "." + exe[i].month + "." + exe[i].year + " " + exe[i].sqNum + " " + exe[i].puNum + " " + exe[i].plNum + Environment.NewLine;
                    avrSq += exe[i].sqNum;
                    avrPu += exe[i].puNum;
                    avrPl += exe[i].plNum;
                }
                text.Text += "\r\nКоличество выполненных упражнений за указанный период:";
                text.Text += "\r\nПриседания: " + 1.0 * avrSq;
                text.Text += "\r\nОтжимания: " + 1.0 * avrPu;
                text.Text += "\r\nПланка: " + 1.0 * avrPl;

            }
        }

        private void zad3_Click(object sender, EventArgs e)
        {
            edit.Enabled = false;
            int max = 0;
            int start = -1;
            int finish = -1;
            int sqSum = 0;
            int puSum = 0;
            int plSum = 0;
            ExercisesDone.ExercisesTypes pop = 0;
            text.Text = "";
            for (int i = 0; i < exe.number; i++)
            {
                if (exe[i].day == Convert.ToInt32(firstDay.Text) && exe[i].month == Convert.ToInt32(firstMonth.Text) && exe[i].year == Convert.ToInt32(firstYear.Text))
                {
                    start = i;
                    break;
                }
            }
            for (int i = 0; i < exe.number; i++)
            {
                if (exe[i].day == Convert.ToInt32(lastDay.Text) && exe[i].month == Convert.ToInt32(lastMonth.Text) && exe[i].year == Convert.ToInt32(lastYear.Text))
                {
                    finish = i;
                    break;
                }
            }
            if (start == -1 || finish == -1 || start > finish)
                text.Text = "Период введён неверно.";
            else
            {
                for (int i = start; i <= finish; i++)
                {
                    text.Text += exe[i].day + "." + exe[i].month + "." + exe[i].year + " " + exe[i].sqNum + " " + exe[i].puNum + " " + exe[i].plNum + Environment.NewLine;
                    sqSum += exe[i].sqNum;
                    puSum += exe[i].puNum;
                    plSum += exe[i].plNum;
                    if (sqSum >= puSum)
                    {
                        max = sqSum;
                        pop = ExercisesDone.ExercisesTypes.Squat;
                        if (plSum >= sqSum)
                        {
                            max = plSum;
                            pop = ExercisesDone.ExercisesTypes.Plank;
                        }
                    }
                    else
                    {
                        max = puSum;
                        pop = ExercisesDone.ExercisesTypes.PushUp;
                        if (plSum >= puSum)
                        {
                            max = plSum;
                            pop = ExercisesDone.ExercisesTypes.Plank;
                        }
                    }
                }

                text.Text += "\r\nСамое популярное упражнение за указанный период:";
                if(pop == ExercisesDone.ExercisesTypes.Squat)
                {
                    text.Text += "\r\nПриседания";
                }
                else if (pop == ExercisesDone.ExercisesTypes.PushUp)
                {
                    text.Text += "\r\nОтжимания";
                }
                else text.Text += "\r\nПланка";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
