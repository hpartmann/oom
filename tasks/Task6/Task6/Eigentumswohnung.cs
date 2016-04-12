using System;
using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
using System.Net;
using Newtonsoft.Json;

namespace Task6
{
    class Eigentumswohnung : IZimmerPreis
    {

        [JsonConstructor]
        //        public Eigentumswohnung(string inputDach, string inputFenster, string inputTüren, int inputIdentifikationsnr)
        public Eigentumswohnung(int Identifikationsnr, int quadratmeter)
        {
         //   if (string.IsNullOrEmpty(inputFenster)) throw new ArgumentException("Fenster müssen vorhanden sein.", nameof(inputFenster));
          //  if (string.IsNullOrEmpty(inputTüren)) throw new ArgumentException("Türen müssen vorhanden sein.", nameof(inputTüren));
          //  this.Fenster = inputFenster;
         //   Dach = inputDach;
         //   Türen = inputTüren;
            this.Identifikationsnr = Identifikationsnr;
            this.quadratmeter = quadratmeter;
        }

       // public string Dach { get; }

      //  public string Fenster { get; }

      //  public string Türen { get; }

        private int Identifikationsnr { get; set; }

        public int quadratmeter { get; }

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

        #region IZimmerPreis implementation

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
