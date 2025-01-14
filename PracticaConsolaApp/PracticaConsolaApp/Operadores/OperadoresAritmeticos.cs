using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaConsolaApp.Operadores
{
    internal class OperadoresAritmeticos
    {
        public int Suma(int numero1, int numero2)
        {
            return numero1 + numero2;
        }

        public int Resta(int numero1, int numero2)
        { 
            return numero1 - numero2; 
        }

        public int Multiplicacion(int numero1, int numero2)
        {
            return numero1 * numero2;
        }

        public int Division(int numero1, int numero2)
        {
            return numero1 / numero2;
        }

        public int Modulo(int numero1, int numero2)
        {
            return numero1 % numero2;
        }
    }
}
