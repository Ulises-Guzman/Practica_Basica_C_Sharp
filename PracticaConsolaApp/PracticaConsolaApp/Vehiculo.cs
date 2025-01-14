using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaConsolaApp
{
    internal class Vehiculo
    {
        // Properties
        public decimal VelocidadMaxima { get; set; }
        public decimal ConsumoPorKilometro { get; set; }

        // Constructor
        public Vehiculo(decimal velocidadMaxima, decimal consumoPorKilometro)
        {
            VelocidadMaxima = velocidadMaxima;
            ConsumoPorKilometro = consumoPorKilometro;
        }

        // Variables: Tipos Primitivos
        int numeroRuedasCoche = 4;
        double myDouble = 2.2;
        decimal myDecimal = 2.2M;
        decimal myDecimal1 = Convert.ToDecimal(2.2);
        char myChar = 'U';

        // Variables: Tipos no Primitivos
        /*
            Tipo:
            Clases
            Structs
            Enum
            Array
            String
            DateTime
        */

        // Metod
        /// <summary>
        /// Explicación general de lo que hace el método
        /// </summary>
        /// <param name="kilometrosTotales"> Explicación del parámetro </param>
        /// <returns> Explicación de lo que devuelve el método </returns>
        public decimal ConsumoTotal(decimal kilometrosTotales)
        {
            return ConsumoPorKilometro * kilometrosTotales;
        }
    }
}



// Comentario de una linea

/*
 Comentarios de mas una linea
*/

/* Modificadores de acceso
    public  - No tiene restriciones de acceso.
    private - Solo son accesibles desde la clase en donde se generan.
    internal - Solo se pude acceder desde los archivos del mismo ensamblado, es decir, desde el propio proyecto.
    protected - lo mismo que lo anterior, con la diferencia que si tenemos una clase que hereda de esta, pueden ser referenciados.
*/

/* namespace - Espacios de nombre
    Sirve para organizar las clases, nombra un scope.
    También es posible teneren el proyecto, varias clases con el mismo nombre, diferenciándose por el namespace.
    Para hacerles refencias hay que, primero en una clase, en el nuevo namespace, agregarla al using - Directivas de uso.
    Luego en la clase principal del programa, es posible hacerle refencia, instanciando un avariable del tipo objeto, si primero se ubica el "using" que corresponde.
    
*/

/* Manejo de valores nulos, para que el compilador no llore, o para que no se rompa el programa en ejecución.
    ! operador de perdonación de nulos, quiere decir: 'tal vez sea null'. El ! debe ubicarse del lado derecho de la asignación
    ? anota que, es posible, que sea null, en la declación de 'tipo' que no permite valores nulos. El ? debe ubicarse al lado izquierdo de la declaracion, en el final del tipo variable u objeto.
    Para completar hay que realizar un chekc de null, una validación:
    Ejemplo:
if mensaje != null
{
    "Realizar operación"
}

if (mensaje is not null) 
{
    "Realizar operación"
}

if (IsNotNull(mensaje))
{
    "Realizar operación"
}

*/