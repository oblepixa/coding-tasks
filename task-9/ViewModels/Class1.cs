using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFBindingExample.ViewModels
{
    public class Class1
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

        public Class1()
        {
            Phones = new ObservableCollection<Phone>();
        }

        public void Add(string Name, int Price, long Number)
        {
                Phones.Add(new Phone(Name, Price, Number)); 
        }
        public void Remove(object SelectedPhone)
        {
            if (SelectedPhone != null)
                Phones.Remove(SelectedPhone as Phone);
        }
        public void Save()
        {
            using (StreamWriter sw = new StreamWriter("file1.txt"))
            {
                foreach (Phone phone in _phones)
                {
                    sw.WriteLine(phone.Name + "/" + phone.Number + "/" + phone.Price);
                }

            }
        }
        public void Open()

        {
            string line = "";
            using (StreamReader sr = new StreamReader("file1.txt"))
            {
                while ((line = sr.ReadLine()) != null)
                {
                    try
                    {
                        Add(line.Split('/')[0], Convert.ToInt32(line.Split('/')[2]), Convert.ToInt64(line.Split('/')[1]));
                    }catch (Exception e)
                    {

                    }
                }
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;

        public void NotifyPropertyChanged(string propName)
        {
            if (this.PropertyChanged != null)
                this.PropertyChanged(this, new PropertyChangedEventArgs(propName));
        }
    }

}
