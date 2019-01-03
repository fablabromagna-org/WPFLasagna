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

namespace NuovaApp
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            int num1, num2;
            //bool conversioneDelNumero1Corretta = Int32.TryParse(numero1.Text, out num1);
            //bool risultato2 = Int32.TryParse(numero2.Text, out num2);
            
            if (Int32.TryParse(numero1.Text, out num1))
            {
                if (Int32.TryParse(numero2.Text, out num2))
                {
                    risultato.Text = (num1 + num2).ToString();
                }
                else
                {
                    risultato.Text = "-";
                    MessageBox.Show("Numero 2 errato");
                }
            }
            else
            {
                risultato.Text = "-";
                MessageBox.Show("Numero 1 errato");
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
