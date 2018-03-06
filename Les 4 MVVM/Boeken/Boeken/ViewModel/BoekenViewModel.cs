using Boeken.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boeken.ViewModel
{
    class BoekenViewModel : BaseViewModel
    {
        private ObservableCollection<Boek> boeken;
        public ObservableCollection<Boek> Boeken
        {
            get { return boeken; }
            set
            {
                boeken = value;
                NotifyPropertyChanged();
            }
        }

        public BoekenViewModel()
        {
            LadenBoeken();
        }

        public void LadenBoeken()
        {
            Boeken = new ObservableCollection<Boek>();

            //geeft running directory van de running appliction
            //encoding nodig om onleesbare tekens weg te werken
            using (StreamReader sr = new StreamReader(AppDomain.CurrentDomain.BaseDirectory + "/Data/boeken.txt", Encoding.UTF7))
            {
                while (!sr.EndOfStream)
                {
                    String line = sr.ReadLine();
                    //parsen van string naar character
                    string[] substrings = line.Split(char.Parse(";"));

                    Boeken.Add(new Boek(substrings[1],substrings[0],substrings[3], AppDomain.CurrentDomain.BaseDirectory + substrings[2]));
                }
            }
        }
    }
}
