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
        
    }

}
