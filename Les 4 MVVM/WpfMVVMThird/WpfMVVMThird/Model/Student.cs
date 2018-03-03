using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WpfMVVMThird.Model
{
    class Student: BaseModel
    {
        private int id;
        private string naam;
        private int klasId;

        public Student(int id, string naam, int klasId)
        {
            Id = id;
            Naam = naam;
            KlasId = klasId;
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

        public int KlasId
        {
            get { return klasId; }

            set
            {
                klasId = value;
                NotifyPropertyChanged();
            }
        }

    }
}
