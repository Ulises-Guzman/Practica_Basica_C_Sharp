using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaConsolaApp3
{
    internal class Auto : Vehiculo
    {
        public Auto(string marca, string modelo) : base(marca, modelo) { }
        public Auto(string marca) : base(marca) { }
    }
}
