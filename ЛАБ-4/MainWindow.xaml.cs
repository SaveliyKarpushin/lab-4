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

namespace ЛАБ_4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        bool results = false;
        int count = 1;
        double a = 0;
        double b = 0;
        bool znak = true;
        public MainWindow()
        {
            InitializeComponent();
            
        }
        private void calculate()
        {
            results = true;
            
            double b = 0;

            switch (count)
            {
                case 1:
                    b = a + double.Parse(TX1.Text);
                    TX1.Text = b.ToString();
                    TX2.Text = TX2.Text + b.ToString();
                    break;
                case 2:
                    b = a - double.Parse(TX1.Text);
                    TX1.Text = b.ToString();
                    TX2.Text = TX2.Text + b.ToString();
                    break;
                case 3:
                    b = a * double.Parse(TX1.Text);
                    TX1.Text = b.ToString();
                    TX2.Text = TX2.Text + b.ToString();
                    break;
                case 4:
                    b = a / double.Parse(TX1.Text);
                    TX1.Text = b.ToString();
                    TX2.Text = TX2.Text + b.ToString();
                    break;
                case 5:
                    b = a*a;
                    TX1.Text = b.ToString();
                    TX2.Text = TX2.Text + b.ToString();
                    break;
                case 6:
                    b = Math.Sqrt(a) ;
                    TX1.Text = b.ToString();
                    TX2.Text = TX2.Text + b.ToString();
                    break;
                case 7:
                    b = Math.Sin(a);
                    TX1.Text = b.ToString();
                    TX2.Text = TX2.Text + b.ToString();
                    break;
                case 8:
                    b = Math.Cos(a);
                    TX1.Text = b.ToString();
                    TX2.Text = TX2.Text + b.ToString();
                    break;
                case 9:
                    b = 1/a;
                    TX1.Text = b.ToString();
                    TX2.Text = TX2.Text + b.ToString();
                    break;
                case 10:
                    b = Math.Pow(a, double.Parse(TX1.Text));
                    TX1.Text = b.ToString();
                    TX2.Text = TX2.Text + b.ToString();
                    break;
                default:
                    break;
            }

        }
        private void bt1_Click(object sender, RoutedEventArgs e)
        {
            if (results)
            {
                results = false;
                TX1.Clear();
                TX1.Text = TX1.Text + bt1.Content;
            }
            else 
            {
                TX1.Text = TX1.Text + bt1.Content;
            }
            TX2.Text = TX2.Text + bt1.Content;
        }

        private void bt2_Click(object sender, RoutedEventArgs e)
        {
            if (results)
            {
                results = false;
                TX1.Clear();
                TX1.Text = TX1.Text + bt2.Content;
            }
            else
            {
                TX1.Text = TX1.Text + bt2.Content;
            }
            TX2.Text = TX2.Text + bt2.Content;
        }

        private void bt3_Click(object sender, RoutedEventArgs e)
        {
            if (results)
            {
                results = false;
                TX1.Clear();
                TX1.Text = TX1.Text + bt3.Content;
            }
            else
            {
                TX1.Text = TX1.Text + bt3.Content;
            }
            TX2.Text = TX2.Text + bt3.Content;
        }

        private void bt4_Click(object sender, RoutedEventArgs e)
        {
            if (results)
            {
                results = false;
                TX1.Clear();
                TX1.Text = TX1.Text + bt4.Content;
            }
            else
            {
                TX1.Text = TX1.Text + bt4.Content;
            }
            TX2.Text = TX2.Text + bt4.Content;
        }

        private void bt5_Click(object sender, RoutedEventArgs e)
        {
            if (results)
            {
                results = false;
                TX1.Clear();
                TX1.Text = TX1.Text + bt5.Content;
            }
            else
            {
                TX1.Text = TX1.Text + bt5.Content;
            }
            TX2.Text = TX2.Text + bt5.Content;
        }

        private void bt6_Click(object sender, RoutedEventArgs e)
        {
            if (results)
            {
                results = false;
                TX1.Clear();
                TX1.Text = TX1.Text + bt6.Content;
            }
            else
            {
                TX1.Text = TX1.Text + bt6.Content;
            }
            TX2.Text = TX2.Text + bt6.Content;
        }

        private void bt7_Click(object sender, RoutedEventArgs e)
        {
            if (results)
            {
                results = false;
                TX1.Clear();
                TX1.Text = TX1.Text + bt7.Content;
            }
            else
            {
                TX1.Text = TX1.Text + bt7.Content;
            }
            TX2.Text = TX2.Text + bt7.Content;
        }

        private void bt8_Click(object sender, RoutedEventArgs e)
        {
            if (results)
            {
                results = false;
                TX1.Clear();
                TX1.Text = TX1.Text + bt8.Content;
            }
            else
            {
                TX1.Text = TX1.Text + bt8.Content;
            }
            TX2.Text = TX2.Text + bt8.Content;
        }

        private void bt9_Click(object sender, RoutedEventArgs e)
        {
            if (results)
            {
                results = false;
                TX1.Clear();
                TX1.Text = TX1.Text + bt9.Content;
            }
            else
            {
                TX1.Text = TX1.Text + bt9.Content;
            }
            TX2.Text = TX2.Text + bt9.Content;
        }

        private void bt0_Click(object sender, RoutedEventArgs e)
        {
        if (results)
            {
                results = false;
                TX1.Clear();
                TX1.Text = TX1.Text + bt0.Content;
            }
            else
            {
                TX1.Text = TX1.Text + bt0.Content;
            }
            TX2.Text = TX2.Text + bt0.Content;
        }

       
        private void __3_Click(object sender, RoutedEventArgs e)
        {
            TX2.Text = TX2.Text + "=";
            calculate();
        }
       
        private void Button_Click(object sender, RoutedEventArgs e)//+
        {
            a = double.Parse(TX1.Text);
            TX1.Clear();
            count = 1;
            znak = true;
            TX2.Text = TX2.Text + "+";
        }

        private void __1_Click(object sender, RoutedEventArgs e)//-
        {
            a = double.Parse(TX1.Text);
            TX1.Clear();
            count = 2;
            znak = true;
            TX2.Text = TX2.Text + "-";
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            a = double.Parse(TX1.Text);
            TX1.Clear();
            count = 3;
            znak = true;
            TX2.Text = TX2.Text + "*";
        }

        private void __2_Click(object sender, RoutedEventArgs e)//деление
        {
            a = double.Parse(TX1.Text);
            TX1.Clear();
            count = 4;
            znak = true;
            TX2.Text = TX2.Text + "/";
        }
        private void Button_Click_2(object sender, RoutedEventArgs e)//^2
        {
            a = double.Parse(TX1.Text);
            count = 5;
            znak = true;
            TX2.Text = TX2.Text + "^2";
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)//корень
        {
            a = double.Parse(TX1.Text);
            count = 6;
            znak = true;
            TX2.Text = "√" + TX2.Text ;
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)//sin
        {
            a = double.Parse(TX1.Text);
            count = 7;
            znak = true;
            TX2.Text = "sin(" + TX2.Text + ")";
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            a = double.Parse(TX1.Text);
            count = 8;
            znak = true;
            TX2.Text = "cos(" + TX2.Text + ")";
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            a = double.Parse(TX1.Text);
            count = 9;
            znak = true;
            TX2.Text = "1/" + TX2.Text;
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            a = double.Parse(TX1.Text);
            TX1.Clear();
            count = 10;
            znak = true;
            TX2.Text = TX2.Text + "^" ;
        }
        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            TX1.Clear();
            TX2.Clear();
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            if (znak == true)
            {
                TX1.Text = "-" + TX1.Text;
                TX2.Text = "-" + TX2.Text;
                
                znak = false;
            }
            else if (znak == false)
            {
                TX1.Text = TX1.Text.Replace("-", "");
                TX2.Text = TX2.Text.Replace("-", "");
                znak = true;
            }
        }
    }
     
}
