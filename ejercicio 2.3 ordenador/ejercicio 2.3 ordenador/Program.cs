using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_2._3_ordenador
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  objeto de la clase Ordenador
        Ordenador ordenador = new Ordenador("HP", "Intel i7", 16, 500);

            // Mostrar los datos del ordenador
            Console.WriteLine(ordenador);

            // Incrementar la capacidad del disco duro
            ordenador.MayorCapacidad();

            // Reducir la capacidad del disco duro
            ordenador.MenorCapacidad();

            // Mostrar los datos actualizados 
            Console.WriteLine(ordenador);
        }
    }
}
