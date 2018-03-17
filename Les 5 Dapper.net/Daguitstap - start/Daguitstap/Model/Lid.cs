namespace Daguitstap.Model
{
    public class Lid : BaseModel
    {
        private int id;
        private string naam;
        private string voornaam;
        private int gaatMee;

        public Lid()
        {
        }

        public Lid(int id, string naam, string voornaam, int gaatMee)
        {
            Id = id;
            Naam = naam;
            Voornaam = voornaam;
            GaatMee = gaatMee;
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

        public string Voornaam
        {
            get { return voornaam; }
            set
            {
                voornaam = value;
                NotifyPropertyChanged();
            }
        }

        public int GaatMee
        {
            get { return gaatMee; }
            set
            {
                gaatMee = value;
                NotifyPropertyChanged();
            }
        }

        public override string ToString()
        {
            return Voornaam + " " + Naam;
        }
    }
}
