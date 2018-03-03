using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WpfMVVMFirst.Model
{
    class Customer : INotifyPropertyChanged
    {
        //variabelen die zullen worden gebruikt voor databinding met CustomerViewModel
        private string name;
        private int amount;
        private string country;

        private int tax;

        public event PropertyChangedEventHandler PropertyChanged;

        // Deze methode wordt opgeroepen in de setter van elke property.  
        // [CallerMemberName Attribute]  is nieuw in NET Framework 4.5.   
        // Dit attribuut zorgt automatisch voor bepalen van de calling propertyName! 
        // Laat toe om bij de properties NotifyPropertyChanged() op te roepen ipv
        // OnPropertyChanged("naam property")

        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        //PropertyChanged event zal worden getriggerd telkens een property via de setter van waarde verandert.

        public string Name
        {
            get{ return name;}
            set{ name = value; NotifyPropertyChanged();}
        }

        public int Amount
        {
            get
            {
                return amount;
            }
            set
            {
                amount = value;
                NotifyPropertyChanged();
            }
        }

        public string Country
        {
            get
            {
                return country;
            }
            set
            {
                country = value;
                NotifyPropertyChanged();
            }
        }

        public int Tax
        {
            get
            {
                return tax;
            }
        }

        public Customer(string name, int amount, string country)
        {
            Name = name;
            Amount = amount;
            Country = country;
        }

        public void CalculateTax()
        {
            if (Amount > 2000)
            {
                tax = 20;
            }
            else if (Amount > 1000)
            {
                tax = 10;
            }
            else
            {
                tax = 5;
            }
            NotifyPropertyChanged("Tax");
        }
    }
}
