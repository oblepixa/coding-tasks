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

namespace WPFBindingExample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        private ObservableCollection<Phone> _phones;
        // коллекция, которую видно при обновлении
        public ObservableCollection<Phone> Phones
        {
            get
            {
                return _phones;
            }
            set
            {
                _phones = value;
                NotifyPropertyChanged("Phones");
            }
        }

        public MainWindow()
        {
            Phones = new ObservableCollection<Phone>();
            InitializeComponent();
            // привязывание коллекции как источнику данных для листбокса
            PhonesListBox.ItemsSource = Phones;
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            Phones.Add(new Phone("Untitled", 10000, 9644820077));
        }

        private void RemoveButton_Click(object sender, RoutedEventArgs e)
        {
            if (PhonesListBox.SelectedItem != null)
                Phones.Remove(PhonesListBox.SelectedItem as Phone);
        }


        public event PropertyChangedEventHandler PropertyChanged;

        public void NotifyPropertyChanged(string propName)
        {
            if (this.PropertyChanged != null)
                this.PropertyChanged(this, new PropertyChangedEventArgs(propName));
        }
    }
}
