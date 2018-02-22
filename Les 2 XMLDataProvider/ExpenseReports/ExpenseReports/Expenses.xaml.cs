using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ExpenseReports
{
    /// <summary>
    /// Interaction logic for Expenses.xaml
    /// </summary>
    public partial class Expenses : Page
    {
        public Expenses()
        {
            InitializeComponent();
        }

        public object Employee
        {
            set { DataContext = value; }
        }

        //constructor in Expenses.xaml 
        public Expenses(object employee) : this()
        {
            Employee = employee;
        }



    }
}
