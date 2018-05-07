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

namespace Task.Pages
{
    /// <summary>
    /// Logika interakcji dla klasy Adres.xaml
    /// </summary>
    public partial class Adres : Page
    {
        public Parameters Parameters;

        public Adres(Parameters parameters)
        {
            InitializeComponent();
            Parameters = parameters;
            AdresBlock.Text = Parameters.Adres;
        }

        private void Button_Click(object sender, RoutedEventArgs e) // wstecz
        {
            Parameters.Adres = AdresBlock.Text;
            this.NavigationService.Navigate(new Nazwisko(Parameters));
        }

        private void Button_Click_1(object sender, RoutedEventArgs e) // dalej
        {
            Parameters.Adres = AdresBlock.Text;
            this.NavigationService.Navigate(new Numer(Parameters));
        }
    }
}
