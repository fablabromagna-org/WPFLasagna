using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace Gelati
{
    class Gelato
    {
        public Gelato() { }
        public Gelato(string riga)
        {
            string[] colonne = riga.Split(';');
            Nome = colonne[0];

            double prezzo;
            double.TryParse(colonne[1], out prezzo);
            Prezzo = prezzo;

            int porzione;
            Int32.TryParse(colonne[2], out porzione);
            Porzione = porzione;

            int voti;
            Int32.TryParse(colonne[3], out voti);
            Voti = voti;

            imgUrl = colonne[4];
        }

        public string Nome { get; set; }
        public double Prezzo { get; set; }
        public string strPrezzo { get { return $"{Prezzo} euro/Kg."; } }
        public int Porzione { get; set; }
        public string strPorzione { get { return $"porzione da {Porzione} gr."; } }
        public int Voti { get; set; }
        public string strVoti { get { return $"{Voti} voti."; } }
        public string imgUrl { get; set; }
        public ImageSource Immagine { get { return new BitmapImage(new Uri(imgUrl, UriKind.Absolute)); } }

    }
}
