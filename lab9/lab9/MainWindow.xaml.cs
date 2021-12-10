using Integrals;
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

namespace lab9
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DefiniteIntegral Integral1;
        DefiniteIntegral Integral2;
        public double S1, S2;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void zad1_Click(object sender, RoutedEventArgs e)
        {
            text.Text = "";

            try
            {
                Integral1 = new DefiniteIntegral(Convert.ToDouble(low1.Text), Convert.ToDouble(up1.Text), Convert.ToInt32(m1.Text));
                Integral2 = new DefiniteIntegral(Convert.ToDouble(low2.Text), Convert.ToDouble(up2.Text), Convert.ToInt32(m2.Text));
                S1 = CalculationMethod.Rectangle(Integral1);
                S2 = CalculationMethod.Rectangle(Integral2);
            }
            catch (IntegralsException ex)
            {
                text.Text = "Ошибка:" + ex.Message;
            }
            catch (Exception ex)
            {
                text.Text = "Ошибка:" + ex.Message;
            }
            


            zad2.IsEnabled = true;
            zad3.IsEnabled = true;
            zad4.IsEnabled = true;
        }

        private void zad2_Click(object sender, RoutedEventArgs e)
        {
            text.Text = "Первый интеграл: " + S1 + "\r\n" + "Второй интеграл: " + S2;
        }

        private void zad3_Click(object sender, RoutedEventArgs e)
        {
            text.Text = "Произведение интеграла1 и 5: " + Integral1 * 5;
        }

        private void zad4_Click(object sender, RoutedEventArgs e)
        {
            text.Text = "Сумма интегралов: " + (Integral1+Integral2);
        }
    }
}
