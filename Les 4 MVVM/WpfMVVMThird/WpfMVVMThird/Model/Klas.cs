using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WpfMVVMThird.Model
{
    class Klas : BaseModel
    {
        private int id;
        private string naam;

        public Klas(int id, string naam)
        {
            Id = id;
            Naam = naam;
        }

        public int Id
        {
            get { return id; }

            set
            {
                id = value;
                NotifyPropertyChanged();
            }
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

    }
}
