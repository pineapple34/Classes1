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

namespace Classes1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Calculate_Click(object sender, RoutedEventArgs e)
        {
            nums nums = new nums();

            try
            {
                double a = double.Parse(TB1.Text);
                double b = double.Parse(TB2.Text);

                output.Content = "Сумма - " + nums.Summ(a, b) + "\n Наибольшее - " + nums.GreatNum(a, b);
            }
            catch (Exception)
            {
                output.Content = "Неверные данные";
            }
        }
    }

    class nums
    {
        public double Summ(double a, double b)
        {
            return a + b;
        }

        public double GreatNum(double a, double b)
        {
            return Math.Max(a, b);
        }
    }
}
