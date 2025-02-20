using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COCHE_5069722
{

    public class frenar : coche
    {
        public frenar(string marca, string modelo, string velocidadmaxima, string velocidadActual) : base(marca, modelo, velocidadmaxima, velocidadActual)
        {

        }
        public void Frenar(int deceleración)
        {
            deceleración = 0;
            Console.WriteLine("Frene a: " + deceleración);
            Console.ReadKey();

        }
    }
}    

