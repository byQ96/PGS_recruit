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

        public Adres(Parameters parameters) // przepisz parametry
        {
            InitializeComponent();
            Parameters = parameters;
            UlicaBlock.Text = Parameters.Ulica;
            NrDomuBlock.Text = Parameters.NrDomu;
            MiejscowoscBlock.Text = Parameters.Miejscowosc;
            KodPoczBlock.Text = Parameters.KodPocz;
        }

        private void Button_Click(object sender, RoutedEventArgs e) // wstecz
        {
            Parameters.Ulica = UlicaBlock.Text;
            Parameters.NrDomu = NrDomuBlock.Text;
            Parameters.Miejscowosc = MiejscowoscBlock.Text;
            Parameters.KodPocz = KodPoczBlock.Text;
            this.NavigationService.Navigate(new Nazwisko(Parameters));
        }

        private void Button_Click_1(object sender, RoutedEventArgs e) // dalej
        {
            Parameters.Ulica = UlicaBlock.Text;
            Parameters.NrDomu = NrDomuBlock.Text;
            Parameters.Miejscowosc = MiejscowoscBlock.Text;
            Parameters.KodPocz = KodPoczBlock.Text;

            if (UlicaBlock.Text == "")
            {
                MessageBox.Show("Wypełnij pole: Ulica", "Alert", MessageBoxButton.OK, MessageBoxImage.Information);
            }

            else if (NrDomuBlock.Text == "")
            {
                MessageBox.Show("Wypełnij pole: Numer Domu", "Alert", MessageBoxButton.OK, MessageBoxImage.Information);
            }

            else if (MiejscowoscBlock.Text == "")
            {
                MessageBox.Show("Wypełnij pole: Miejscowość", "Alert", MessageBoxButton.OK, MessageBoxImage.Information);
            }

            else if (KodPoczBlock.Text == "")
            {
                MessageBox.Show("Wypełnij pole: Kod pocztowy", "Alert", MessageBoxButton.OK, MessageBoxImage.Information);
            }

            else
            {
                this.NavigationService.Navigate(new Numer(Parameters));
            }
        }
    }
}
