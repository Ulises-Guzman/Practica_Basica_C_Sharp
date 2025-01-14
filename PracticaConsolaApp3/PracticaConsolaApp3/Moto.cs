using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaConsolaApp3
{
    internal class Moto : Vehiculo
    {
        public int Cilindrada { get; set; }
        public int Rodado { get; set; }

        /*
        public Moto()
        {
            Marca = "Honda";
            Modelo = "XR";
        }
        */

        public Moto(string marca, string modelo, int cilindrada, int rodado) : base(marca, modelo)
        {
            Cilindrada = cilindrada;
            Rodado = rodado;
        }

        public Moto(string marca) : base(marca) { }

        public void Arrancar()
        {
            Console.WriteLine("La moto arranca");
        }
        public void Acelerar()
        {
            Console.WriteLine("La moto acelera");
        }
        public void Apagar()
        {
            Console.WriteLine("La moto para");
        }
    }
}
