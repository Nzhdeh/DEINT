﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Core;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0xc0a

namespace _11_SplitView
{
    /// <summary>
    /// Página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void lBoxIcons_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            //switch () {
            //    case "First":
            //        txbTitulo.Text = "Ejercicio final layouts";
            //        imgGato.Visibility = Visibility.Collapsed;
            //        frmPrincipal.Navigate(typeof(PrimeraPagina));
            //        break;
            //    case "Second":
            //        txbTitulo.Text = "Ejercicio de controles";
            //        imgGato.Visibility = Visibility.Collapsed;
            //        frmPrincipal.Navigate(typeof(SegundaPagina));
            //        break;
            //    case "Third":
            //        txbTitulo.Text = "Ejercicio Adaptative layout";
            //        imgGato.Visibility = Visibility.Collapsed;
            //        frmPrincipal.Navigate(typeof(SegundaPagina));
            //        break; }

            if (First.IsSelected)
            {
                txbTitulo.Text = "Ejercicio final layouts";
                imgGato.Visibility = Visibility.Collapsed;
                frmPrincipal.Navigate(typeof(PrimeraPagina));
            }
            else if (Second.IsSelected)
            {
                txbTitulo.Text = "Ejercicio de controles";
                imgGato.Visibility = Visibility.Collapsed;
                frmPrincipal.Navigate(typeof(SegundaPagina));
            }
            else {
                txbTitulo.Text = "Ejercicio Adaptative layout";
                imgGato.Visibility = Visibility.Collapsed;
                frmPrincipal.Navigate(typeof(TerceraPagina));
            }

        }

        private void HamburgerButton_Click(object sender, RoutedEventArgs e)
        {
            spV.IsPaneOpen = !spV.IsPaneOpen;
        }
    }
}
