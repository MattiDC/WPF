using System.Collections.ObjectModel;
using System.Windows.Input;
using WpfMVVMSecond.Model;

namespace WpfMVVMSecond.ViewModel
{
    class StudentenViewModel : BaseViewModel
    {
        private int nummer;

        public StudentenViewModel()
        {
            LadenStudenten();
            KoppelenCommands();
        }

        private void LadenStudenten()
        {
            Studenten = new ObservableCollection<Student>();
            Studenten.Add(new Student("Jef Verboven", "2 ITF", 2));
            Studenten.Add(new Student("Hans Verkerken", "2 ITF", 1));
            Studenten.Add(new Student("Lies Pauwels", "2 ITF", 3));
            Studenten.Add(new Student("Stefanie Moreels", "2 ITF", 2));
        }

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

        //code ICommands
        private ICommand addStudentCommand;
        private ICommand deleteStudentCommand;
  
        public ICommand AddStudentCommand { get { return addStudentCommand; } set { addStudentCommand = value; } }
        public ICommand DeleteStudentCommand { get { return deleteStudentCommand; } set {deleteStudentCommand = value; } }

        //kopelen van commands aan gewenste actie
        private void KoppelenCommands()
        {
            AddStudentCommand = new BaseCommand(Toevoegen);
            DeleteStudentCommand = new BaseCommand(Verwijderen);
        }

        private void Toevoegen()
        {
            Studenten.Add(new Student("Student " + (++nummer), "2 ITF", nummer));
        }

        //voordat we kunnen verwijderen moeten we eerst kijken of we een item hebben geselecteerd
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

        private void Verwijderen()
        {
            if (SelectedItem != null)
            {
                Studenten.Remove(SelectedItem);
            }
        }
    }

}
