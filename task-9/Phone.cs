using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFBindingExample
{
    public class Phone : INotifyPropertyChanged	//важно унаследовать интерфейс для работы с байндингами
    {
		//внутренние скрытые поля
		private string _name;
		private int _price;
		private long _number;
		const int MaxLength = 11;

		//внешнее поле с именем
		public string Name
		{
			get
			{
				return _name;
			}
			set
			{
				if (_name != value)
				{
					_name = value;
					//вызываем функцию, которая сообщает об обновлении поля Name
					this.NotifyPropertyChanged("Name");
				}
			}
		}

		//внешнее поле с ценой
		public int Price
		{
			get
			{
				return _price;
			}
			set
			{
				if (_price != value)
				{
					bool Changed = int.TryParse(value.ToString(), out _price);
					//вызываем функцию, которая сообщает об обновлении поля Price
					if (Changed) this.NotifyPropertyChanged("Price");
				}
			}
		}
		public long Number
		{
			get
			{
				return _number;
			}
			set
			{
				if (_number != value)
				{ 
					_number = value;
					if (_number > 10000000000 )
                    {
						_number = 0;
					}
					
				//вызываем функцию, которая сообщает об обновлении поля Name
				this.NotifyPropertyChanged("Number");
				}
			}
		}

		//пустой конструктор класса
		public Phone() { }

		//конструктор класса для заполнения при создании объекта
		public Phone(string Name, int Price, long Number)
        {
			this.Name = Name;
			this.Price = Price;
			this.Number = Number;
        }

		//событие, которое срабатывает при обновлении объекта
		public event PropertyChangedEventHandler PropertyChanged;

		//функция, которую надо запустить, чтобы сообщить об обновлении объекта
		public void NotifyPropertyChanged(string propName)
		{
			if (this.PropertyChanged != null)
				this.PropertyChanged(this, new PropertyChangedEventArgs(propName));
		}
	}
}
