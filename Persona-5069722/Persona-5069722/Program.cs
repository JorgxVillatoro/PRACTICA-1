using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persona_5069722
{
    internal class Program
    {
        static void Main(string[] args)
        {

            persona personaL = new persona("Verdes", "187", "85", "v");
            Console.WriteLine("Descripcion de la persona ");
            Console.WriteLine("ojos " + personaL.ojos);
            Console.WriteLine("altura " + personaL.altura);
            Console.WriteLine("peso" + personaL.peso);
            Console.WriteLine("Sexo" + personaL.sexo);

            personaL.hablar("me llamo jorge ");
            Console.WriteLine("color de mis ojos " + personaL.ojos);
            personaL.correr(1000);
            Console.WriteLine("mi peso actual es " + personaL.peso);

           
          


        }

    }
}
