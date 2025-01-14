using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaConsolaApp.Operadores
{
    internal class OperadoresAsignacion
    {
        public string AsignarValor()
        {
            string frase = "Asignamos el valor con =";
            return frase;
        }

        public int Incremento(int numero)
        {
            return numero++;
        }

        public int Decremento(int numero)
        {
            return numero--;
        }

        // Primero muestra el número y después incrementa
        public void EjemploIncrementoDetras(int numero)
        {
            Console.WriteLine(numero++);
        }

        // Primero incrementa y después muestra el número
        public void EjemploIncrementoDelante(int numero)
        {
            Console.WriteLine(++numero);
        }
    }
}
