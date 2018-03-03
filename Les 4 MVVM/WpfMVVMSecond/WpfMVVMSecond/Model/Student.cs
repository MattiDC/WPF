using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace WpfMVVMSecond.Model
{
    class Student : INotifyPropertyChanged
    {
        private string naam;
        private string jaar;
        private int groep;

        public Student(string naam, string jaar, int groep)
        {
            Naam = naam;
            Jaar = jaar;
            Groep = groep;
        }

        public string Naam
        {
            get { return naam; }

            set
            {
                naam = value;
                NotifyPropertyChanged();
            }
        }

        public string Jaar
        {
            get { return jaar; }

            set
            {
                jaar = value;
                NotifyPropertyChanged();
            }
        }

        public int Groep
        {
            get { return groep; }

            set
            {
                groep = value;
                NotifyPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
