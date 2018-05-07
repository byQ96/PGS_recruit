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

namespace Task.Pages
{
    /// <summary>
    /// Logika interakcji dla klasy Numer.xaml
    /// </summary>
    public partial class Numer : Page
    {
        public Numer()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e) // wstecz
        {
            this.NavigationService.Navigate(new Adres());
        }

        private void Button_Click_1(object sender, RoutedEventArgs e) // dalej
        {
            this.NavigationService.Navigate(new Sum());
        }
    }
}
