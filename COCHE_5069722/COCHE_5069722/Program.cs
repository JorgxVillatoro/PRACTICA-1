using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COCHE_5069722
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //llamando la clase coche
            coche coche = new coche("Nisan ", "GT-R", "100", "10");
            Console.WriteLine("Marca del auto: " + coche.Marca);
            Console.WriteLine("Modelo del auto: " + coche.Modelo);
            Console.WriteLine("Velocidad maxima del auto: " + coche.VelocidadMaxima);
            Console.WriteLine("Velocidad actual del auto: " + coche.VelocidadActual);

            coche.Acelerar(5);
            coche.Decelera(5);

            frenar autofrenado = new frenar("Ford", "Fiesta", "100", "10");
            autofrenado.Frenar(0);


            Console.ReadKey();
        }
    }
}
