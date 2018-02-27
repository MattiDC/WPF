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
using System.ComponentModel;

namespace PlantenBIS
{
    /// <summary>
    /// Interaction logic for PageOverzicht.xaml
    /// </summary>
    public partial class PageOverzicht : Page
    {
        public PageOverzicht()
        {
            InitializeComponent();
            ListBoxKleur.Items.GroupDescriptions.Add(new PropertyGroupDescription("light"));
            ListBoxKleur.Items.SortDescriptions.Add(new SortDescription("light", ListSortDirection.Ascending));
            ListBoxKleur.Items.SortDescriptions.Add(new SortDescription("common", ListSortDirection.Ascending));
        }
    
        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            ListBoxKleur.DataContext = ((MainWindow)Window.GetWindow(this)).ComboboxKleuren.SelectedItem;
            
        }

        private void ListBoxKleur_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            PageDetail detail = new PageDetail(ListBoxKleur.SelectedItem);
            ((MainWindow)Window.GetWindow(this)).frame.Content = detail;
        }
    }
}
