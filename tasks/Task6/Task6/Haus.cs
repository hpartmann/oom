using System;
using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
using System.Globalization;
using System.Net;
using Newtonsoft.Json;

namespace Task6
{
    public class Haus : IZimmerPreis
    {
        /*private decimal Fixpreis = 250000;*/
        private decimal member_Preis;

        //public Haus(string inputDach, string inputFenster, string inputTüren, int inputZimmer, decimal inputPreis)
        //    : this(inputDach, inputFenster, inputTüren, inputZimmer, inputPreis)
        //{
        //}

        /// <summary>
        /// Erzeugt ein neues Haus
        /// </summary>
        /// <param name="Dach"></param>
        /// <param name="Fenster"></param>
        /// <param name="Türen"></param>
        /// <param name="Preis"></param>
        /// <param name="Zimmer"></param>
        //[JsonConstructor]
        public Haus(string Dach, string Fenster, string Türen, int Zimmer, decimal Preis)
        {
            if (string.IsNullOrEmpty(Dach)) throw new ArgumentException("Dach muss vorhanden sein.", nameof(Dach));
            if (string.IsNullOrEmpty(Fenster)) throw new ArgumentException("Fenster müssen vorhanden sein.", nameof(Fenster));
            if (string.IsNullOrEmpty(Türen)) throw new ArgumentException("Türen müssen vorhanden sein.", nameof(Türen));
            if (Zimmer <= 0) throw new ArgumentException("Zimmer müssen vorhanden sein.", nameof(Zimmer));
            this.Dach = Dach;
            this.Fenster = Fenster;
            this.Türen = Türen;
            this.Zimmer = Zimmer;
            UpdatePreis(Preis);
        }


        public string Dach { get; }

        public string Fenster { get; }

        public string Türen { get; }

        public int Zimmer
        {
            get; set;
          /*set
            {
                if (Zimmer < 4) member_Preis = Fixpreis;
            }*/
        }

        public void UpdatePreis(decimal neuerPreis)
        {
            if (neuerPreis < 0) throw new ArgumentException("Preis darf nicht negativ sein.", nameof(neuerPreis));
            member_Preis = neuerPreis;
        }

        #region IZimmerPreis implementation

        public int AnzZimmer => Zimmer;

        public decimal Preis
        {
            get { return member_Preis; }
           // set
           //     {
           //         member_Preis = value;
           //     }
        }

        #endregion
    }
}
