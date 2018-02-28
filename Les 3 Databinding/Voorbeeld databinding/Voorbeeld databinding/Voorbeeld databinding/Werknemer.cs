using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Voorbeeld_databinding
{
    class Werknemer : INotifyPropertyChanged
    {
        private string naam;
        private string voornaam;
        private string afdeling;

        public string Naam
        {
            get
            {
                return naam;
            }

            set
            {
                naam = value;
                OnPropertyChanged("Naam");
                OnPropertyChanged("NaamVoluit");
            }
        }

        public string Voornaam
        {
            get
            {
                return voornaam;
            }

            set
            {
                voornaam = value;
                OnPropertyChanged("Voornaam");
                OnPropertyChanged("NaamVoluit");
            }
        }

        public string Afdeling
        {
            get
            {
                return afdeling;
            }

            set
            {
                afdeling = value;
                OnPropertyChanged("Afdeling");
            }
        }

        public string NaamVoluit
        {
            get
            {
                return voornaam + " " + naam;
            }
        }

        public Werknemer(string naam, string voornaam, string afdeling)
        {
            Naam = naam;
            Voornaam = voornaam;
            Afdeling = afdeling;
        }

        public override string ToString()
        {
            return naam + ' ' + voornaam;
        }

        // Declareren event
        public event PropertyChangedEventHandler PropertyChanged;
        // OnPropertyChanged zorgt voor update property value in alle bindings
        private void OnPropertyChanged(string propertyName)
        {
            var handler = PropertyChanged;
            handler?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}