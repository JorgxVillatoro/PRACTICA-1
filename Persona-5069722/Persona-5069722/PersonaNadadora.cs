using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persona_5069722
{
    internal class PersonaNadadora:persona
    {
        public PersonaNadadora(string ojos, string altura, string peso,
            string sexo) : base(ojos, altura, peso, sexo) {

        }
        public void Nadar()
        {
            //LA practica de la natacion hara volver al peso inicial 
            Console.WriteLine("Nadando para volver al peso ideal ");
            this.peso = "85";
        }
        


    }
}
