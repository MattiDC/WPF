namespace BeheerContacten.Model
{
    public class ContactPersoon: BaseModel
    {
        private int id;
        private string naam;
        private string email;
        
        public int ID
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
                NotifyPropertyChanged();
            }
        }

        public string Naam
        {
            get
            {
                return naam;
            }

            set
            {
                naam = value;
                NotifyPropertyChanged();
            }
        }

        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                email = value;
                NotifyPropertyChanged();
            }
        }

    }
}