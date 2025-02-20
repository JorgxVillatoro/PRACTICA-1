using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COCHE_5069722
{
    public class coche
    {

        //atributos que iran en el elemento "programa"
        public string Marca;
        public string Modelo;
        public string VelocidadMaxima;
        public string VelocidadActual;

        //construstor
        public coche(string marca, string modelo, string velocidadmaxima, string velocidadActual)
        {
            this.Marca = marca;
            this.Modelo = modelo;
            this.VelocidadMaxima = velocidadmaxima;
            this.VelocidadActual = velocidadActual;

        }
        //declaramos las variables del string en parentesis
        public string marca;
        public string modelo;
        public string velocidadmaxima;
        public string velocidadActual;

        //formula para acelerar
        public void Acelerar(int aceleración)
        {
            aceleración += 5;
            Console.WriteLine("Acelerando de 5 en 5: " + aceleración);
            Console.ReadKey();
        }

        //formula para decelerar
        public void Decelera(int deceleración)
        {
            deceleración -= 5;
            Console.WriteLine("Decelerando de 5 en 5: " + deceleración);
            Console.ReadKey();

        }

    }
}
