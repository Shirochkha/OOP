using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;

namespace lab7
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int productNum;
        int purchaseNum;
        Purchase[] purchases;
        Purchase.Tovar[] tovars;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void output_Click(object sender, RoutedEventArgs e)
        {
            text.Text = "";
            text.IsEnabled = true;
            zad1.IsEnabled = true;
            zad2.IsEnabled = true;
            zad3.IsEnabled = true;
            zad4.IsEnabled = true;

            //Продукты
            StreamReader f = new StreamReader("D:\\goods.txt");
            string txt = f.ReadToEnd();
            f.Close();

            string[] str = txt.Split(new String[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
            productNum = str.Length;
            tovars = new Purchase.Tovar[productNum];

            for (int i = 0; i < productNum; i++)
            {
                while (str[i].Contains("  "))
                    str[i] = str[i].Replace("  ", " ");
                string name = str[i].Substring(0, str[i].IndexOf(' '));
                str[i] = str[i].Remove(0, str[i].IndexOf(' ') + 1);
                tovars[i] = new Purchase.Tovar(name, Convert.ToDouble(str[i]));
            }

            //Покупки
            f = new StreamReader("D:\\purchases.txt");
            txt = f.ReadToEnd();
            f.Close();
            
            str = txt.Split(new String[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
            purchaseNum = str.Length;
            purchases = new Purchase[purchaseNum];

            for (int i = 0; i < purchaseNum; i++)
            {
                while (str[i].Contains("  "))
                    str[i] = str[i].Replace("  ", " ");
                string name = str[i].Substring(0, str[i].IndexOf(' '));
                str[i] = str[i].Remove(0, str[i].IndexOf(' ') + 1);
                double sale = Convert.ToDouble(str[i]);
                Purchase.Tovar goods= new Purchase.Tovar("",0);
                foreach (Purchase.Tovar k in tovars)
                {
                    if(k.name == name)
                    {
                        goods = k;
                        break;
                    }
                }
                

                if (sale == 0)
                {
                    purchases[i] = new PurchaseNoSale(goods);
                }
                else if (sale == 10)
                {
                    purchases[i] = new Purchase10Sale(goods);
                }
                else if (sale == 25)
                {
                    purchases[i] = new Purchase25Sale(goods);
                }
                else purchases[i] = new Purchase50Sale(goods);
            }

            for (int i = 0; i < purchaseNum; i++)
            {
                text.Text += purchases[i].tovar.name + " " + purchases[i].GetFinalePrice() + Environment.NewLine;
            }


        }

        private void zad1_Click(object sender, RoutedEventArgs e)
        {
            text.Text = "";
            double sum = 0;
            for (int i = 0; i < purchaseNum; i++)
            {
                sum += purchases[i].GetFinalePrice();
            }
            text.Text += sum;
        }

        private void zad2_Click(object sender, RoutedEventArgs e)
        {
            text.Text = "";
            
            for (int i = 0; i < productNum; i++)
            {
                double sumTovara = 0;
                int kol = 0;
                for (int m = 0; m < purchaseNum; m++)
                {
                    if (purchases[m].tovar.name == tovars[i].name)
                    {
                        sumTovara += purchases[m].GetFinalePrice();
                        kol++;
                    }
                }
                sumTovara /= kol;
                text.Text += purchases[i].tovar.name + " " + sumTovara + Environment.NewLine;
            }

        }

        private void zad3_Click(object sender, RoutedEventArgs e)
        {
            text.Text = "";

            for (int i = 0; i < productNum; i++)
            {
                int kol = 0;
                for (int m = 0; m < purchaseNum; m++)
                {
                    if (purchases[m].tovar.name == tovars[i].name)
                    {
                        kol++;
                    }
                }
                text.Text += purchases[i].tovar.name + " " + kol + Environment.NewLine;
            }
        }

        private void zad4_Click(object sender, RoutedEventArgs e)
        {
            text.Text = "";
            double sumWithSale = 0;
            for (int i = 0; i < purchaseNum; i++)
            {
                if (purchases[i].sale > 0)
                {
                    sumWithSale++;
                }
            }

            text.Text += sumWithSale;
        }
    }
}
