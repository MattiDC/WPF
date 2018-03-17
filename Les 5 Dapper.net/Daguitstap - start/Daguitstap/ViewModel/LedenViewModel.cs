using System.Collections.ObjectModel;
using Daguitstap.Model;
using System.Windows.Input;

namespace Daguitstap.ViewModel
{
    public class LedenViewModel : BaseViewModel
    {
        public LedenViewModel()
        {
            LeesGegevens();
            KoppelenCommands();
        }

        // collection that allows code outside the collection be aware of when changes to the collection occur.
        private ObservableCollection<Lid> leden;
        public ObservableCollection<Lid> Leden
        {
            get { return leden; }
            set {
                leden = value;
                NotifyPropertyChanged();
            }
        }

        private ObservableCollection<Lid> deelnemers;
        public ObservableCollection<Lid> Deelnemers
        {
            get { return deelnemers; }
            set
            {
                deelnemers = value;
                NotifyPropertyChanged();
            }
        }

        private Lid currentLid;
        public Lid CurrentLid
        {
            get { return currentLid; }
            set {
                currentLid = value;
                NotifyPropertyChanged();
            }
        }

        // commands
        private void KoppelenCommands()
        {
            InschrijvenCommand = new BaseCommand(Inschrijven);
            UitschrijvenCommand = new BaseCommand(Uitschrijven);
        }

        public ICommand InschrijvenCommand { get; set; }
        public ICommand UitschrijvenCommand { get; set; }

        public void Inschrijven()
        {
            if (currentLid != null)
            {
                LidDataService lidDS = new LidDataService();
                lidDS.Inschrijven(currentLid, true);

                //Refresh
                LeesGegevens();
            }
        }

        public void Uitschrijven()
        {
            if (currentLid != null)
            {
                LidDataService lidDS = new LidDataService();
                lidDS.Inschrijven(currentLid, false);

                //Refresh
                LeesGegevens();
            }
        }

        private void LeesGegevens()
        {
            LidDataService lidDS = new LidDataService();

            // een lid neemt niet per se deel
            Leden = new ObservableCollection<Lid>(lidDS.GetDeelnemers(false));
            Deelnemers = new ObservableCollection<Lid>(lidDS.GetDeelnemers(true));
        }

    }
}
