﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BilletLibrary
{
    /// <summary>
    /// Bilklasse som opretter et objekt af bil når det intialiseres
    /// </summary>
    /// <returns></returns>
    public class Bil
    {
        public string Nummerplade { get; set; }
        public DateTime Dato { get; set; }

        /// <summary>
        /// Metode til at printe prisen på bilen
        /// </summary>
        /// <returns></returns>
        public decimal Pris()
        {
            int pris = 240;
            return pris;
        }

        /// <summary>
        /// Metode til at printe køretøjets navn ud
        /// </summary>
        /// <returns></returns>
        public string Køretøj()
        {
            string bil = "Bil";
            return bil;
        }
    }


}
