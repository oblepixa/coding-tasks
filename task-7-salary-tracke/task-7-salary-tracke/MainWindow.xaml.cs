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

namespace task_7_salary_tracke
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            if (RadioProd.IsChecked.Value)
            {

                try
                {
                    //Новый объект класса продавец
                    Class_seller mySeller = new Class_seller();

                    //вызываем метод
                    //начальная зп продавца

                    mySeller.SetBasicSalary(Double.Parse(TextZpbaz.Text));
                    TextBlock myTextBlock = new TextBlock();
                    myTextBlock.Text = "Зарплата: " + mySeller.GetSalary(Convert.ToInt32(TextSmena.Text)); //получаем зп
                    Stack_Seller.Children.Add(myTextBlock);
                }
                catch (Exception ex)
                {
                    LabelZpbaz.Foreground = Brushes.Red;
                }
            }
            if (RadioStprod.IsChecked.Value)
            {
                try
                {
                    Class_seniorseller mySenior = new Class_seniorseller();
                    mySenior.SetBasicSalary(Double.Parse(TextZpbaz.Text));
                    mySenior.P(Double.Parse(TextPrib.Text));
                    TextBlock myTextBlock = new TextBlock();
                    myTextBlock.Text = "Зарплата: " + mySenior.GetSalary(Convert.ToInt32(TextSmena.Text));
                    Stack_seniorseller.Children.Add(myTextBlock);
                }
                catch (Exception ex)
                {
                    LabelZpbaz.Foreground = Brushes.Red;
                }
            }
            if (RadioMened.IsChecked.Value)
            {
                try
                {
                    Class_manager myManager = new Class_manager();
                    myManager.SetBasicSalary(Double.Parse(TextZpbaz.Text));
                    myManager.P(Double.Parse(TextPrib.Text));
                    TextBlock myTextBlock = new TextBlock();
                    myTextBlock.Text = "Зарплата: " + myManager.GetSalary(Convert.ToInt32(TextSmena.Text));
                    Stack_manager.Children.Add(myTextBlock);
                }
                catch (Exception ex)
                {
                    LabelZpbaz.Foreground = Brushes.Red;
                }
            }
            if (RadioRider.IsChecked.Value)
            {

                try
                {
                    Class_driver myDriver = new Class_driver();
                    myDriver.SetBasicSalary(Double.Parse(TextZpbaz.Text));
                    TextBlock myTextBlock = new TextBlock();
                    myTextBlock.Text = "Зарплата: " + myDriver.GetSalary(Convert.ToInt32(TextSmena.Text));
                    Stack_driver.Children.Add(myTextBlock);
                }
                catch (Exception ex)
                {
                    LabelZpbaz.Foreground = Brushes.Red;
                }
            }
        }
        private void TextRadius_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (LabelZpbaz.Foreground != Brushes.Black)
                LabelZpbaz.Foreground = Brushes.Black;
        }
    }
}
