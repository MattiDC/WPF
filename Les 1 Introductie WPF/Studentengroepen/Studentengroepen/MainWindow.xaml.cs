using System;
using System.IO;
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

namespace Studentengroepen
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            createButtons();
        }

        public void createButtons()
        {
            string[] namen = Directory.GetFiles("Bestanden");
            List<String> bestanden = new List<string>();

            foreach(string i in namen)
            {
                //string trimmen
                String bestand = i.Remove(0, 10); // "bestand/ weghalen
                bestand = bestand.TrimEnd('.', 't', 'x', 't'); // .txt weghalen

                //knop maken
                Button knop = new Button();
                knop.Name = "Button" + bestand; //naam knop
                knop.Content = bestand;
                knop.Click += Button_Click;

                //knop toevoegen
                StackPanelButtons.Children.Add(knop);
            }
            

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //gegevens van button ophalen
            Button btn = (Button)sender;
            String titel =  btn.Content.ToString();
            int teller = 1;

            //text titel aanpassen
            TextBlockTitel.Text = "Overzicht studenten uit " + titel;

            //text overzicht reset
            TextBlockOverzicht.Text = "";
           

            //data uitlezen text files

            using (StreamReader sr = new StreamReader("Bestanden/" + titel + ".txt" , Encoding.UTF7))
            {
                
                while(sr.Peek() > 0)
                {
                    String lijn = teller + ". " + sr.ReadLine() + System.Environment.NewLine;
                    TextBlockOverzicht.Text += lijn; // lijn toevoegen aan textblok
                    teller++;
                }
            }
        }
    }
}
