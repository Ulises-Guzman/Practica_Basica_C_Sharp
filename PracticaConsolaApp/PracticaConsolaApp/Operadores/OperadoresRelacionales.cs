using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaConsolaApp.Operadores
{
    internal class OperadoresRelacionales
    {
        public bool MayorQue(int numero1, int numero2)
        {
            return numero1 > numero2;
        }

        public bool MayorIgualQue(int numero1, int numero2)
        {
            return numero1 >= numero2;
        }

        public bool MenorQue(int numero1, int numero2)
        {
            return numero1 < numero2;
        }

        public bool MenorIgualque(int numero1, int numero2)
        {
            return numero1 <= numero2;
        }

        public bool IgualQue(int numero1, int numero2)
        {
            return numero1 == numero2;
        }

        public bool DistintoQue(int numero1, int numero2)
        {
            return numero1 != numero2;
        }
    }
}
