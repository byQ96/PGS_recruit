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
    /// Logika interakcji dla klasy Nazwisko.xaml
    /// </summary>
    public partial class Nazwisko : Page
    {
        public Parameters Parameters;

        public Nazwisko(Parameters parameters)
        {
            InitializeComponent();
            Parameters = parameters;
            NazwiskoBlock.Text = Parameters.Nazwisko;
        }

        private void Button_Click(object sender, RoutedEventArgs e) // wstecz
        {
            Parameters.Nazwisko = NazwiskoBlock.Text;
            this.NavigationService.Navigate(new Imie(Parameters));
        }

        private void Button_Click_1(object sender, RoutedEventArgs e) // dalej
        {
            Parameters.Nazwisko = NazwiskoBlock.Text;
            this.NavigationService.Navigate(new Adres(Parameters));
        }
    }
}
