
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

namespace task_3_wpf_calculator
{

    /// <summary>                                                  
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        float a, b;
        int count;
        bool znaki = true;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void B0_Click(object sender, RoutedEventArgs e)
        {
            textB.Text = textB.Text + 0;
        }

        private void B1_Click(object sender, RoutedEventArgs e)
        {
            textB.Text = textB.Text + 1;
        }

        private void B2_Click(object sender, RoutedEventArgs e)
        {
            textB.Text = textB.Text + 2;
        }

        private void B3_Click(object sender, RoutedEventArgs e)
        {
            textB.Text = textB.Text + 3;
        }

        private void B4_Click(object sender, RoutedEventArgs e)
        {
            textB.Text = textB.Text + 4;
        }

        private void B5_Click(object sender, RoutedEventArgs e)
        {
            textB.Text = textB.Text + 5;
        }

        private void B6_Click(object sender, RoutedEventArgs e)
        {
            textB.Text = textB.Text + 6;
        }

        private void B7_Click(object sender, RoutedEventArgs e)
        {
            textB.Text = textB.Text + 7;
        }

        private void B8_Click(object sender, RoutedEventArgs e)
        {
            textB.Text = textB.Text + 8;
        }

        private void B9_Click(object sender, RoutedEventArgs e)
        {
            textB.Text = textB.Text + 9;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (textB.Text.Length != 0)
            {
                a = float.Parse(textB.Text);
                textB.Text = String.Empty;
                count = 1;
                label1.DataContext = a.ToString() + "+";
                znaki = true;
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (textB.Text.Length != 0)
            {
                a = float.Parse(textB.Text);
                textB.Text = String.Empty;
                count = 2;
                label1.DataContext = a.ToString() + "-";
                znaki = true;
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            if (textB.Text.Length != 0)
            {
                a = float.Parse(textB.Text);
                textB.Text = String.Empty;
                count = 3;
                label1.DataContext = a.ToString() + "*";
                znaki = true;
            }
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            if (textB.Text.Length != 0)
            {
                a = float.Parse(textB.Text);

                textB.Text = String.Empty;
                count = 4;
                label1.DataContext = a.ToString() + "/";
                znaki = true;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            if (!textB.Text.Contains(","))
                textB.Text += ",";
            textB_TextChanged();
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            b = float.Parse(textB.Text);
            textB.Text = calculate(a, b, count);

            label1.DataContext = "";
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            textB.Text = "";
            label1.DataContext = "";
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            if (znaki == true)
            {
                textB.Text = "-" + textB.Text;
                znaki = false;
            }
            else if (znaki == false)
            {
                textB.Text = textB.Text.Replace("-", "");
                znaki = true;
            }
        }

        private void textB_TextChanged()
        {

            if (textB.Text.StartsWith(",")) textB.Text = textB.Text.Substring(1);

        }

        private string calculate(float a, float b, int variant)
        {
            float c;
            switch (variant)
            {
                 case 1:
                     c = a + b;
                     break;
                 case 2:
                    c = a - b;
                    break;
                case 3:
                    c = a * b;
                    break;
                case 4:
                    c = a / b;
                    break;

                 default:
                    c = 0;
                   break;
            }
            return c.ToString();


        }
    }
}
