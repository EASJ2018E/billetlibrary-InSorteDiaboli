using System;

namespace BilletLibrary
{
    /// <summary>
    /// Abstract klasse som alle køretøjer nedarver fra
    /// </summary>
    public abstract class Køretøj
    {


        public abstract decimal Pris();
        public abstract string KøretøjNavn();
    }
}
