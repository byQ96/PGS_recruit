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
    /// Logika interakcji dla klasy Sum.xaml
    /// </summary>
    public partial class Sum : Page
    {
        public Parameters Parameters;

        public Sum(Parameters parameters) // przepisanie i wypisanie parametrów
        {
            InitializeComponent();
            Parameters = parameters;

            Console.WriteLine(Parameters.ToString());
            Tekst.Text = Parameters.ToString();
        }

        private void Button_Click(object sender, RoutedEventArgs e) // wstecz
        {
            this.NavigationService.Navigate(new Numer(Parameters));
        }

        private void Button_Click_1(object sender, RoutedEventArgs e) // zakończ
        {
            System.Windows.Application.Current.Shutdown();
        }
    }
}
