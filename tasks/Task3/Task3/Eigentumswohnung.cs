using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Eigentumswohnung : IZimmerPreis
    {

        public Eigentumswohnung(string inputFenster, string inputTüren, int inputIdentifikationsnr)
        {
            if (string.IsNullOrEmpty(inputFenster)) throw new ArgumentException("Fenster müssen vorhanden sein.", nameof(inputFenster));
            if (string.IsNullOrEmpty(inputTüren)) throw new ArgumentException("Türen müssen vorhanden sein.", nameof(inputTüren));
            this.Fenster = inputFenster;
            Türen = inputTüren;
            Identifikationsnr = inputIdentifikationsnr;
        }

        public string Fenster { get; }

        public string Türen { get; }

        private int Identifikationsnr { get; set; }


        #region IZimmerPreis implementation

        public int Zimmer
        {
            get
            {
                if (Identifikationsnr < 92000) return 3;
                else if (Identifikationsnr < 93000) return 4;
                else if (Identifikationsnr < 94000) return 5;
                else return 99999;
            }
        }

        public int AnzZimmer => Zimmer;

        public decimal Preis
        {
            get
            {
                if (Identifikationsnr < 92000) return 30000;
                else if (Identifikationsnr < 93000) return 40000;
                else if (Identifikationsnr < 94000) return 50000;
                else return 99999;
            }
        }

        #endregion
    }
}
