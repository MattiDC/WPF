using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfMVVMFirst.Model;
using System.Windows.Input;

namespace WpfMVVMFirst.ViewModel
{
    //Bestaat uit properties om instanties van één of meer Models door te spelen aan de View
    class CustomerViewModel : BaseViewModel
    {
        private Customer customer;

        public Customer Customer
        {
            get { return customer; }
            set
            {
                customer = value;
                NotifyPropertyChanged();
            }
        }

        public CustomerViewModel()
        {
            LadenCustomer();
            KoppelenCommand();
        }

        private void LadenCustomer()
        {
            Customer = new Customer("Bert Boonen", 2000, "Netherlands");
        }

        //code ICommand
        private ICommand calculateTaxCommand;

        public ICommand CalculateTaxCommand
        {
            get { return calculateTaxCommand; }
            set { calculateTaxCommand = value; }
        }

        private void KoppelenCommand()
        {
            CalculateTaxCommand = new BaseCommand(BerekenTax);
        }

        private void BerekenTax()
        {
            Customer.CalculateTax();
        }


    }
}
