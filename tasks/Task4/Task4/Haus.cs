using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Net;
using Newtonsoft.Json;

namespace Task4
{
    public class Haus : IZimmerPreis
    {
        /*private decimal Fixpreis = 250000;*/
        private decimal member_Preis;

        /// <summary>
        /// Erzeugt ein neues Haus
        /// </summary>
        /// <param name="Dach"></param>
        /// <param name="Fenster"></param>
        /// <param name="Türen"></param>
        /// <param name="Preis"></param>
        /// <param name="Zimmer"></param>
        public Haus(string inputDach, string inputFenster, string inputTüren, int inputZimmer, decimal inputPreis)
        {
            if (string.IsNullOrEmpty(inputDach)) throw new ArgumentException("Dach muss vorhanden sein.", nameof(inputDach));
            if (string.IsNullOrEmpty(inputFenster)) throw new ArgumentException("Fenster müssen vorhanden sein.", nameof(inputFenster));
            if (string.IsNullOrEmpty(inputTüren)) throw new ArgumentException("Türen müssen vorhanden sein.", nameof(inputTüren));
            if (inputZimmer <= 0) throw new ArgumentException("Zimmer müssen vorhanden sein.", nameof(inputZimmer));
            this.Dach = inputDach;
            this.Fenster = inputFenster;
            Türen = inputTüren;
            Zimmer = inputZimmer;
            UpdatePreis(inputPreis);
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
            set
                {
                    member_Preis = value;
                }
        }

        #endregion
    }
}
