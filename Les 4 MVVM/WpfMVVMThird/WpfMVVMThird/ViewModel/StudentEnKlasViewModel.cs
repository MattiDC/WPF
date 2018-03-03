using System.Collections.ObjectModel;
using System.Windows.Input;
using WpfMVVMThird.Model;

namespace WpfMVVMThird.ViewModel
{
    class StudentEnKlasViewModel : BaseViewModel
    {
        private int newId = 0;
        
        private ObservableCollection<Student> studenten;
        public ObservableCollection<Student> Studenten
        {
            get
            {
                return studenten;
            }
            set
            {
                studenten = value;
                NotifyPropertyChanged();
            }
        }

        public ObservableCollection<Klas> Klassen { get; set; }

        public ICommand AddStudentCommand { get; set; }
        public ICommand DeleteStudentCommand { get; set; }
        
        public StudentEnKlasViewModel()
        {
            LadenStudenten();
            LadenKlassen();
            KoppelenCommands();
        }
        
        private void LadenStudenten()
        {
            Studenten = new ObservableCollection<Student>();
            Studenten.Add(new Student(++newId, "Jef Verboven", 201));
            Studenten.Add(new Student(++newId, "Hans Verkerken", 201));
            Studenten.Add(new Student(++newId, "Lies Pauwels", 202));
            Studenten.Add(new Student(++newId, "Stefanie Moreels", 203));
        }

        private void LadenKlassen()
        {
            Klassen = new ObservableCollection<Klas>();
            Klassen.Add(new Klas(201, "2 ITF 1"));
            Klassen.Add(new Klas(202, "2 ITF 2"));
            Klassen.Add(new Klas(203, "2 ITF 3"));
        }

        private void KoppelenCommands()
        {
            AddStudentCommand = new BaseCommand(Toevoegen);
            DeleteStudentCommand = new BaseCommand(Verwijderen);
        }
        
        private void Toevoegen()
        {
            Studenten.Add(new Student(++newId, "New student", 201));
            SelectedItem = Studenten[Studenten.Count - 1];
        }

        private void Verwijderen()
        {
            if (SelectedItem != null)
            {
                Studenten.Remove(SelectedItem);
            }
        }
        
        private Student selectedItem;
        public Student SelectedItem
        {
            get { return selectedItem; }
            set
            {
                selectedItem = value;
                NotifyPropertyChanged();
            }
        }
    }
}
