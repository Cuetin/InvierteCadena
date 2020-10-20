using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace InvierteCadena
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Invertir_Click(object sender, RoutedEventArgs e)
        {
            TextBox tb = Entrante;
            Label eti = Salida;
            int i;
            string aux = "";
            for (i = 0; i < tb.Text.Length; i++)
                aux += tb.Text[tb.Text.Length - i - 1];
            eti.Content = aux;
        }

        private void Mayusculas_Click(object sender, RoutedEventArgs e)
        {
            TextBox tb = Entrante;
            Label eti = Salida;
            string aux = tb.Text;
            aux = aux.ToUpper();
            eti.Content = aux;

        }

        private void Ambas_Click(object sender, RoutedEventArgs e)
        {
            TextBox tb = Entrante;
            Label eti = Salida;
            int i;
            string aux = "";
            for (i = 0; i < tb.Text.Length; i++)
                aux += tb.Text[tb.Text.Length - i - 1];
            aux = aux.ToUpper();
            eti.Content = aux;
        }

        private void Capicua_Click(object sender, RoutedEventArgs e)
        {
            TextBox tb = Entrante;
            Label eti = ResuCapicua;
            int i;
            string aux = "";

            for (i = 0; i < tb.Text.Length; i++)
                aux += tb.Text[tb.Text.Length - i - 1];

            if (aux == tb.Text)
                eti.Content = "ES CAPICUA";
            else
                eti.Content = "NO ES CAPICUA";



        }
    }
}
