using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Persona_5069722
{
    public class persona
    {
        public persona( string ojos,string peso, string sexo, string altura)  { 
        
        this.ojos = ojos;
            this.peso = peso;
            this.sexo=sexo;
           this.altura = altura;
        
        }
        public string ojos;
        public string peso;
        public string sexo;
        public string altura;

        //acciones 
        public void hablar(string texto)
        {
            Console.WriteLine("Voy a decir"+ texto);

        }
        public void comer(double calorias) 
        {
            //se indican las calorias que se ganan al comer 
            Console.WriteLine("Ganando" + calorias + "calorias ");
            this.peso += calorias / 1000;
        }
        public void correr(double calorias)
        {
            // Se indican las caloias que se pierden al correr 
            Console.WriteLine("perdiendo" + calorias + "alorias ");
            this.peso = Convert.ToString(calorias/1000);
        }
    }
}

