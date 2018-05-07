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
using Task.Pages;

namespace Task
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Parameters parameters = new Parameters();

        public MainWindow()
        {
            InitializeComponent();

            Imie ImiePage = new Imie(parameters);
            Frame.NavigationService.Navigate(ImiePage);
        }

        private void Frame_Navigated(object sender, NavigationEventArgs e)
        {

        }
    }
}
