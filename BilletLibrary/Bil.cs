using System;
using System.Collections.Generic;
using System.Text;

namespace BilletLibrary
{
    /// <summary>
    /// Bilklasse som opretter et objekt af bil når det intialiseres
    /// </summary>
    /// <returns></returns>
    public class Bil : Køretøj
    {

        public Bil()
        {
            
        }

        public Bil(string nummerplade, DateTime dato) : base(nummerplade, dato)
        {
        }

        /// <summary>
        /// Metode til at printe prisen på bilen
        /// </summary>
        /// <returns></returns>
        public override decimal Pris()
        {
            return 240;
        }

        /// <summary>
        /// Metode til at printe køretøjets navn ud
        /// </summary>
        /// <returns></returns>
        public override string KøretøjNavn()
        {
            return "Bil";
        }
    }


}
