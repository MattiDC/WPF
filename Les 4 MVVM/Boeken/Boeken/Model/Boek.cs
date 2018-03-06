using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boeken.Model
{
    class Boek : BaseModel
    {
        private string titel;
        private string auteur;
        private string samenvatting;
        private string foto;

        //constructor boek
        public Boek(string titel, string auteur, string samenvatting, string foto)
        {
            Titel = titel;
            Auteur = auteur;
            Samenvatting = samenvatting;
            Foto = foto;
        }

        //getters en setters
        public string Titel
        {
            get => titel; set
            {
                titel = value;
                NotifyPropertyChanged();
            }
        }
        public string Auteur
        {
            get => auteur; set
            {
                auteur = value;
                NotifyPropertyChanged();
            }
        }
        public string Samenvatting
        {
            get => samenvatting; set
            {
                samenvatting = value;
                NotifyPropertyChanged();
            }
        }
        public string Foto
        {
            get => foto; set
            {
                foto = value;
                NotifyPropertyChanged();
            }
        }
    }
}
