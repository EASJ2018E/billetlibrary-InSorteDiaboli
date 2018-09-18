﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BilletLibrary
{
    /// <summary>
    /// Bilklasse som opretter et objekt af mc når det intialiseres
    /// </summary>
    /// <returns></returns>
    public class MC : Køretøj
    {
        public string Nummerplade { get; set; }
        public DateTime Dato { get; set; }

        /// <summary>
        /// Metode til at printe prisen på MC
        /// </summary>
        /// <returns></returns>
        public override decimal Pris()
        {
            int pris = 125;
            return pris;
        }

        /// <summary>
        /// Metode til at printe navnet på køretøjet
        /// </summary>
        /// <returns></returns>
        public override string KøretøjNavn()
        {
            string køretøj = "MC";
            return køretøj;
        }
    }
}