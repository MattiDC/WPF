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

namespace PlantenBIS
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ComboboxKleuren_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if((frame.Content != null) && (frame.Content is PageOverzicht))
            {
                // Listbox op PageOverzicht gelijk stellen aan geselecteerd item van Combobox op MainWindow
                ((PageOverzicht)frame.Content).ListBoxKleur.DataContext = ComboboxKleuren.SelectedItem;
            }
        }

        private void BackwardButton_Click(object sender, RoutedEventArgs e)
        {
            if(frame.NavigationService.CanGoBack)
            {
                frame.NavigationService.GoBack();
            }
        }

        private void ForewardButton_Click(object sender, RoutedEventArgs e)
        {
            if (frame.NavigationService.CanGoForward)
            {
                frame.NavigationService.GoForward();
            }
        }
    }
}
