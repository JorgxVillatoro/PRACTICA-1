using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_2._3_ordenador
{
    internal class Ordenador
    {
        // Atributos (propiedades)
        public string Marca { get; set; }
        public string Procesador { get; set; }
        public int Memoria { get; set; }
        public int DiscoDuro { get; set; }

        // Constructor
        public Ordenador(string marca, string procesador, int memoria, int discoDuro)
        {
            Marca = marca;
            Procesador = procesador;
            Memoria = memoria;
            DiscoDuro = discoDuro;
        }

       
        public override string ToString()
        {
            return $"Marca: {Marca}, Procesador: {Procesador}, Memoria: {Memoria}GB, Disco Duro: {DiscoDuro}GB";
        }

      
        public void MayorCapacidad()
        {
            DiscoDuro += 100;
            Console.WriteLine($"Nuevo tamaño del disco duro: {DiscoDuro}GB");
        }

        //  reducir la capacidad del disco duro
        public void MenorCapacidad()
        {
            if (DiscoDuro > 100)
            {
                DiscoDuro -= 100;
                Console.WriteLine($"Nuevo tamaño del disco duro: {DiscoDuro}GB");
            }
            else
            {
                Console.WriteLine("No se puede reducir más el tamaño del disco duro.");
            }

        }
    }
}
