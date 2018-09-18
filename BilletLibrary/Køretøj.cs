using System;

namespace BilletLibrary
{
    /// <summary>
    /// Abstract klasse som alle køretøjer nedarver fra
    /// </summary>
    public abstract class Køretøj
    {
        public virtual string Nummerplade { get; set; }
        public DateTime Dato { get; set; }


        public abstract decimal Pris();
        public abstract string KøretøjNavn();

        public Køretøj(string nummerplade, DateTime dato)
        {
            if (Nummerplade.Length <= 7)
            {
                Nummerplade = nummerplade;
            }
            else
            {
                throw new ArgumentException("Nummerpladen må ikke være over 7 tegn");
            }
            Dato = dato;    
        }
        

        public Køretøj()
        {
            
        }

        public decimal UsesBrobizz()
        {
                return Pris()*(0.95m);  
        }
    }
}
