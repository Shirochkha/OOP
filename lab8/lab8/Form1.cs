using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using People;

namespace lab8
{
    public partial class Form1 : Form
    {
        int vseNum;
        Human[] vse;
        string[] str;
        //int k = 0;
        //Pupils[] pupils;
        public int room;
        public string group;
        string plays;
        public Form1()
        {
            InitializeComponent();

            StreamReader f = new StreamReader("D:\\infoLab8.txt");
            string txt = f.ReadToEnd();
            f.Close();

            str = txt.Split(new String[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
            vseNum = str.Length;
            vse = new Human[vseNum];
            string[] s;

            for (int i = 0; i < vseNum; i++)
            {
                while (str[i].Contains("  "))
                   str[i] = str[i].Replace("  ", " ");
                s = str[i].Split(' ');
                string lastName = s[0];
                int yearBirthday = int.Parse(s[1]);
                string status = s[2];
                plays = s[3];

                if (status == "студент")
                {
                    string nameStudyBuilding = plays;
                    group = s[4];

                    int[] marks = new int[4];
                    marks[0] = Convert.ToInt32(s[5]);
                    marks[1] = Convert.ToInt32(s[6]);
                    marks[2] = Convert.ToInt32(s[7]);
                    marks[3] = Convert.ToInt32(s[8]);

                    vse[i] = new Students(lastName, yearBirthday, status, nameStudyBuilding, group, marks);
                }
                else if (status == "школьник")
                {
                    string nameStudyBuilding = plays;
                    room = int.Parse(s[4]);

                    int[] marks = new int[4];
                    marks[0] = Convert.ToInt32(s[5]);
                    marks[1] = Convert.ToInt32(s[6]);
                    marks[2] = Convert.ToInt32(s[7]);
                    marks[3] = Convert.ToInt32(s[8]);

                    vse[i] = new Schoolchildren(lastName, yearBirthday, status, nameStudyBuilding, room, marks);
                }
                else
                {
                    string job = plays;
                    double[] salary = new double[5];
                    salary[0] = Convert.ToDouble(s[4]);
                    salary[1] = Convert.ToDouble(s[5]);
                    salary[2] = Convert.ToDouble(s[6]);
                    salary[3] = Convert.ToDouble(s[7]);
                    salary[4] = Convert.ToDouble(s[8]);

                    vse[i] = new Working(lastName, yearBirthday, status, job, salary);
                }

                //if(status == "школьник" || status == "студент")
                //{
                //    pupils[k] = (Pupils)vse[i];
                //    k++;
                //}
            }
        }

        private void zad1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            for (int i = 0; i < vseNum; i++)
            {
                //if (vse[i].status == "школьник")
                //{
                //    if (vse[i].yearBirthday < 2009)
                //    {
                //        this.textBox1.ForeColor = System.Drawing.Color.Yellow;
                //    }
                //    else this.textBox1.ForeColor = System.Drawing.Color.Black;
                //}
                textBox1.Text += vse[i].InfoHuman() + Environment.NewLine;
            }
        }

        private void zad2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";

            IEnumerable<string> query = from word in str
                                        orderby word.Substring(0, 1)
                                        select word;

            foreach (string s in query)
            {
                string q = s;
                while (q.Contains("  "))
                    q = q.Replace("  ", " ");
                string status = q.Split(' ')[2];

                if (status == "школьник" || status == "студент")
                {
                    textBox1.Text += s + Environment.NewLine;
                }
            }
 
        }

        private void zad3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            int k = 0; //количество двоечников
            int q = 0; //количество школьников
            int m = 0; //сколько школ не совпало
            for (int i = 0; i < vseNum; i++)
            {
                if (vse[i].status == "школьник")
                {
                    q++;
                    Schoolchildren a = (Schoolchildren)vse[i];
                    if (a.nameStudyBuilding == textBox2.Text)
                    {
                        if (vse[i].Info() <= 2)
                        {
                            k++;

                            textBox1.Text += vse[i].InfoHuman(room) + Environment.NewLine;
                        }
                    }
                    else
                    {
                        m++; 
                    }
                }
            }

            if (q == m)
            {
                textBox1.Text = "Такой школы нет";
            }
            else if (k > 0)
            {
                textBox1.Text += "В школе " + k + " двоечник(а,ов)" + Environment.NewLine;
            }
            else textBox1.Text = "В этой школе нет двоечников";
        }

        private void zad4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            for (int i = 0; i < vseNum; i++)
            {
                if (vse[i].status == "студент")
                {
                    if(vse[i].Info() > 8)
                    {
                        textBox1.Text += vse[i].InfoHuman(group) + Environment.NewLine;
                    }
                }
            }
        }
    }
}
