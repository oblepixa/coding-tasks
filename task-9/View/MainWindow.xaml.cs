using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
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
using WPFBindingExample.ViewModels;

namespace WPFBindingExample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        Class1 handler;
        

        public MainWindow()
        {
            handler = new Class1();
            InitializeComponent();
            // привязывание коллекции как источнику данных для листбокса
            PhonesListBox.ItemsSource = handler.Phones;
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                handler.Add(NameTextBox.Text, Convert.ToInt32(PriceTextBox.Text), Convert.ToInt64(NumberTextBox.Text));
            }
            catch (FormatException ex)
            {

            }
        }

        private void RemoveButton_Click(object sender, RoutedEventArgs e)
        {
            handler.Remove(PhonesListBox.SelectedItem);
        }
        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            handler.Save();
        }
        private void OpenButton_Click(object sender, RoutedEventArgs e)
        {
            handler.Open();
        }





        public event PropertyChangedEventHandler PropertyChanged;

        public void NotifyPropertyChanged(string propName)
        {
            if (this.PropertyChanged != null)
                this.PropertyChanged(this, new PropertyChangedEventArgs(propName));
        }
    }
}
