using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;


namespace Voorbeeld_databinding
{
    class Werknemers : ObservableCollection<Werknemer>
    {
        public Werknemers()
        {
            Add(new Werknemer("Peeters", "Jef", "Marketing"));
            Add(new Werknemer("Verboven", "Anna", "Sales"));
            Add(new Werknemer("De Winter", "Karen", "Marketing"));
            Add(new Werknemer("Dierckx", "Daisy", "R&D"));
            Add(new Werknemer("Aerts", "Gert", "Sales"));
            Add(new Werknemer("Horemans", "Sam", "ICT"));
            Add(new Werknemer("Somers", "Dirk", "Marketing"));
            Add(new Werknemer("Geerts", "Tuur", "R&D"));
            Add(new Werknemer("Vervloesem", "An", "Sales"));
            Add(new Werknemer("Berx", "Karl", "ICT"));
        }
    }
}