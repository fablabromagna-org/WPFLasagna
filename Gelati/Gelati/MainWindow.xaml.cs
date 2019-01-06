using System;
using System.Collections.Generic;
using System.IO;
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

namespace Gelati
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Gelato> gelati = new List<Gelato>();

        public MainWindow()
        {
            InitializeComponent();

            StreamReader fin = new StreamReader("gelati.csv");
            fin.ReadLine();

            while (!fin.EndOfStream)
            {
                gelati.Add(new Gelato(fin.ReadLine()));
            }

            fin.Close();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            lvGelati.ItemsSource = gelati;
        }


        private void VotaClick(object sender, RoutedEventArgs e)
        {
            Button b = sender as Button;
            if (b != null)
            {
                Gelato g = b.Tag as Gelato;
                if (g != null)
                    g.Voti++;

                lvGelati.Items.Refresh();
            }
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            StreamWriter fout = new StreamWriter("gelati.csv");
            fout.WriteLine("Nome;Prezzo;Porzione;Voti;imgUrl");

            foreach (Gelato g in gelati)
                fout.WriteLine($"{g.Nome};{g.Prezzo};{g.Porzione};{g.Voti};{g.imgUrl}");
            fout.Close();
        }
    }
}
