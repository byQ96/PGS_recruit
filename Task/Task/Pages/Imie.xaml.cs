﻿using System;
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
    /// Logika interakcji dla klasy Imie.xaml
    /// </summary>
    public partial class Imie : Page
    {
        public Parameters Parameters;

        public Imie(Parameters parameters) // przepisanie parametrów
        {
            InitializeComponent();
            Parameters = parameters;
            ImieBlock.Text = Parameters.Imie;
        }

        private void Button_Click(object sender, RoutedEventArgs e) // dalej
        {
            Parameters.Imie = ImieBlock.Text;

            if (ImieBlock.Text == "")
            {
                MessageBox.Show("Wypełnij pole: Imię", "Alert", MessageBoxButton.OK, MessageBoxImage.Information);
            }

            else
            {
                this.NavigationService.Navigate(new Nazwisko(Parameters));
            }
        }
    }
}
