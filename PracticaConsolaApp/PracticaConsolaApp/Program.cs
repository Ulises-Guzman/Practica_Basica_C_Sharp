using PracticaConsolaApp.Espacio2;
using PracticaConsolaApp;
using Microsoft.VisualBasic;
using System.Text;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;
using System;


internal class Program
{
    public const int NumeroMeses = 12;

    //public TimeSpan(long ticks);
    //public TimeSpan(int days, int hours, int minutes, int seconds);
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        //Console.WriteLine("Número de meses: " + NumeroMeses);

        // Inicialización de una clase
        TestClass testClass = new TestClass();

        DiasSemana diasSemana = DiasSemana.Lunes;
        int[] myArray = new int[5];
        string myString = "hola";
        //DateTime myDateTime = new DateTime(2024, 11, 20);
        DateTime myDateTime = DateTime.Now;
        Console.WriteLine("La fecha de hoy es:" + myDateTime);

        // Entrada por teclado
        /* Console.Write("Ingrese un nombre: ");
        //String entradaTeclado = Console.ReadLine();
        //Console.WriteLine("Hemos introducido: " + entradaTeclado);
        */

        //Console.Write("Ingresa tu edad: ");
        /*string entradaTeclado = Console.ReadLine();
        int edad = int.Parse(entradaTeclado);
        Console.WriteLine("El doble de tu edad es: " + edad * 2);
        */

        // Muestra el código ASCII de la tecla presionada
        /* Console.Write("Presione una tecla: ");
        int caracterASCII = Console.Read();
        Console.WriteLine("El código ASCII es: " + caracterASCII);

        // Impresion por pantalla con formato
        Console.BackgroundColor = ConsoleColor.Green;
        Console.ForegroundColor = ConsoleColor.Black;
        Console.WriteLine("{0,5} {1,5}", 123, 456);
        Console.ReadKey();
        Console.ResetColor();
        */

        /*
        // Resolucion de problema
        Console.Write("Por favor, Ingrese su edad: ");
        string edadHijo = Console.ReadLine()!;
        Console.Write("Ingrese la edad de su padre: ");
        string? edadPadre = Console.ReadLine();
        if (edadHijo != null && edadPadre != null)
        {
            int diferenciaEdad = int.Parse(edadPadre) - int.Parse(edadHijo);
            Console.WriteLine("La diferencia de edad es: " + diferenciaEdad + " años.");
            // Con formato
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("La diferencia de edad es: {0}", diferenciaEdad + " años.");
            Console.ResetColor();
        }
        */

        // Probando las variales tipo Caracteres, ArrayChar y String
        // Definir una variable del tipo caracter
        char myCaracteres = 'a';

        // Definir un array de carateres
        char[] myArrayCaracteres = ['U', 'l', 'i'];

        // Convertir un array de crateres en una variable tipo string
        string myStringCaracter = new string(myArrayCaracteres);

        Console.WriteLine(myStringCaracter + " " + myCaracteres);

        // Concatenar variables tipos string
        string myConcatenacion = myStringCaracter + " " + "Holis...";

        // Interpolar variales tipos string
        string myInterpolacion = $"Interpolando variables, hola {myStringCaracter}";

        // Como formatear un string
        Console.WriteLine(string.Format("La temperatura es {0}°C", 20.3));

        // Metodos del tipo string
        string myString1 = "Tengo un vaso lleno de";

        Console.WriteLine(myString1.ToUpper());
        Console.WriteLine(myString1.ToLower());
        Console.WriteLine(myString1.Equals("Tengo un vaso lleno de"));
        Console.WriteLine(myString1.IndexOf('v'));
        Console.WriteLine(myString1 + " jugo de naraja");
        Console.WriteLine(myString1.Contains("lleno"));
        // Hay muchos mas...

        // StringBuilder, concatenando variable en un mismo espacio de memoria.
        StringBuilder sbEjemplo = new StringBuilder("Hola,");
        sbEjemplo.Append("como estás...");
        Console.WriteLine(sbEjemplo);

        // Arrays
        // Declaración de un array
        // string[] myArrayNombres = new string[10];

        // Otra forma
        //int[] myArrayNumero = {1, 2, 3, 4, 5};
        //int[] myArrayNumero1 = [1, 2, 3, 4, 5];

        // Acceder y mostrar valores de un array
        //for (int i = 0; i < 10; i++)
        //{
        //    Console.WriteLine($"Los nombres son {myArrayNombres}");
        //}

        //for (int i = 0; i < myArrayNumero.Length; i++)
        //{
        //    Console.Write($"La lista de números es: {myArrayNumero[i]}");
        //}

        // Array Multidimensional o Matriz
        // Declaración de un matriz
        string[,] myMatriz = new string[2, 3];

        string[,] ciudades = new string[2, 2];

        // Asignar valor a la matriz
        ciudades[0, 0] = "2932";
        ciudades[0, 1] = "Punta Alta";
        ciudades[1, 0] = "0291";
        ciudades[1, 1] = "Bahia Blanca";

        // Acceder y mostrar los valores de una matriz
        //for (int i = 0; i < 1; i++)
        //{
        //    for (int j = 0; j < 1; j++)
        //    {
        //        Console.WriteLine($"Los codigos y ciudades son: {ciudades[i, j]}");
        //    }
        //}

        /*
        // Matriz Jagged "Dentado"
        // Declaración de una matriz jagged
        string[][] provincias = new string[3][];
        provincias[0] = new string[3];
        provincias[1] = new string[2];
        provincias[2] = new string[4];

        // Otra forma de declaración expresión de colección
       // string[][] provincias1 = [new string[3], new string[1], new string[4]];

        // Asignar valores ala matriz jagged
        provincias[0][0] = "Entre Rios";
        provincias[0][1] = "Paraná";
        provincias[0][2] = "Federación";

        provincias[1][0] = "La Pampa";
        provincias[1][1] = "Santa Rosa";

        provincias[2][0] = "Buenos Aires";
        provincias[2][1] = "Punta Alta";
        provincias[2][2] = "Bahia Blanca";
        provincias[2][3] = "Mar del PLata";

        // Acceder y mostrar los valores de una matriz jagged
        // Para mostrar cada registro primero hay que consultar que tamaño tiene.
        int reg = 0;
        for (int i = 0; i < provincias.Length; i++)
        {
            reg = i + 1;
            Console.WriteLine($"> Registro: {reg}");

            // Muestra el registro dentado, consultado si el elemento esta vacio
            for (int j = 0; j < provincias[i].Length; j++)
            {
                if (provincias[i][j] != "")
                    Console.Write($" {provincias[i][j]}");
                else
                    Console.Write(" ");
            }
            Console.WriteLine();
        }
        */

        // Listas List<T>
        // Caracteristica pricipal es que es mutable
        //implementan IEnumerable<T> la cual es una interfaz que permite ejecutar consultas LINQ.

        List<string> provincias = new List<string>();
        List<string> ciudadesBuenosAires = new List<string>();
        List<string> provincias1 = new List<string>();

        provincias.Add("Buenos Aires");
        provincias.Add("La Pampa");
        provincias.Add("Cordoba");

        provincias1.Add("Entre Rios");
        provincias1.Add("Corrientes");

        ciudadesBuenosAires.Add("Punta Alta");
        ciudadesBuenosAires.Add("Bahia Blanca");
        ciudadesBuenosAires.Add("Mar del Plata");
        ciudadesBuenosAires.Add("La Plata");

        // Agregar una lista a otra lista
        provincias.AddRange(provincias1);


        // Trabajar con listas
        // Para iterar la lista
        foreach (string provincia in provincias)
        {
            Console.WriteLine($"Listado: {provincia}");
        }

        /* Esto no es posible, porque no se puede modificar cuando se esta leyendo la lista y agregar en el medio. 
        // Agregar una lista dentro de otra
        foreach (string item in provincias)
        {   
            if (item == "Buenos Aires")
            {
                provincias.AddRange(ciudadesBuenosAires);
            }
        }
        Console.WriteLine(provincias);
        */


        /* LINQ
            LINQ es un lenguaje de consultas de bases de datos, esa fue la intención en un principio,
        pero se dieron cuenta de que List<T>, es también, el resultado de una consulta sobre una BBDD,
        asique se lo puede aprovechar, además, para realizar filtrado.
        Hay que utilizar un tipo, que extienda, de la clase IEnumerable<T>, como ser List<T> 
        */

        IEnumerable<string> ciudadFiltrada = ciudadesBuenosAires.Where(c => c.Contains('u'));
        foreach (string ciudad in ciudadFiltrada)
        {
            Console.WriteLine(ciudad);
        }

        // DateTime
        DateTime testFecha = new DateTime(1984, 8, 7, 15, 15, 11);
        DateTime testFecha2 = DateTime.Now;
        Console.WriteLine(testFecha);
        Console.WriteLine(testFecha2);

        // Localización con CulterInfo
        // El tipo CulterInfo permite setear el idioma y pais para crear datos del tipo DateTime,
        // esto evita que se produzcan errores en ejecución.
        // Si está mal seteado el CulterInfo la ejecución del programa se detendrá en error.
        CultureInfo cultureInfoAR = new CultureInfo("es-AR");

        // Convertir un string a un tipo DateTime
        DateTime testFecha3 = DateTime.Parse("25/12/2024 00:00:01 AM", cultureInfoAR);
        DateTime testFecha4 = Convert.ToDateTime("25/12/2024 00:00:01 AM", cultureInfoAR);
        DateOnly testFecha5 = DateOnly.Parse("01/01/2025", cultureInfoAR);
        DateTime tetsFecha6 = Convert.ToDateTime("01/01/2025", cultureInfoAR);

        Console.WriteLine(testFecha3);
        Console.WriteLine(testFecha4);
        Console.WriteLine(testFecha5);
        Console.WriteLine(tetsFecha6);

        // Propiedades del tipo DateTime
        int dia = testFecha3.Day; // Devuelve el número de día del mes.
        int mes = testFecha3.Month; // Devuelve el número del mes.
        int anio = testFecha3.Year; // Devulve el número de año.
        int hora = testFecha3.Hour; // Devuelve la hora.
        int minuto = testFecha3.Minute; // Devuelve los minutos.
        int segundo = testFecha3.Second; // Devuelve los segndos.
        string diaSemana = testFecha3.DayOfWeek.ToString(); // Devulve el nombre del día de la semana.
        int diaAnio = testFecha3.DayOfYear; // Devuelve el número del día del año.

        // Métodos del tipo DateTime
        testFecha3.AddDays(1); // Agrega un día a la fecha actual.
        testFecha3.AddMonths(1);
        testFecha3.AddYears(1);
        testFecha3.AddDays(-1); // Resta un día a la fecha actual.
        testFecha3.AddMonths(-1);
        testFecha3.AddYears(-1);

        // Tipo TimeSpan
        // Permite añadir tiempo, tener en cuenta el tipo en concreto.
        // Debe definirse en el constructor la estructura del tipo de dato en concreto.
        //TimeSpan timepo = new TimeSpan(2, 3, 40, 11);

        DateTime testFecha7 = new DateTime(2019, 01, 01);
        //fecha tendrá el valor de 1 de enero de 2019 a las 00h 00m

        TimeSpan tiempo = new TimeSpan(1, 5, 30, 5);
        //creamos un objeto timespan con valor de 1 dia, 5 horas, 30 minutos, 5 segundos

        DateTime fechaActualizada = testFecha7.Add(tiempo);
        //Sumamos el tiempo a la fecha anterior
        //Resultado: 2 de enero de 2019 a las 5:30 de la mañana.

        Console.WriteLine(testFecha7);
        Console.WriteLine(tiempo);
        Console.WriteLine(fechaActualizada);

        // Comparación de Fechas
        // Es posible comparar utilizando el método DateTime.Compare(fecha1, fecha2)
        // dentro del tipo estático DateTime
        // o 
        // Utilizar la propia fecha y compararla con la segunda, fecha1.CompareTo(fecha2)

        DateTime fecha1 = new DateTime(1984, 08, 07, 15, 15, 11);
        DateTime fecha2 = new DateTime(2024, 12, 31);
        int fechaResultado1 = DateTime.Compare(fecha1, fecha2);
        int fechaResultado2 = fecha1.CompareTo(fecha2);

        /*
        Si la comparación de la fecha da por resultado
        fechaResultado1 < 0     # la primera fecha es anterior
        fechaResultado1 == 0    # es la misma fecha
        fechaResultado1 > 0     # la segunda fecha es anterior
        */

        int comparacionFecha1 = DateTime.Compare(fecha1, fecha2);
        int comparacionFecha2 = fecha1.CompareTo(fecha2);

        if (comparacionFecha1 < 0)
        {
            Console.WriteLine("La primer fecha es anterior");
        }
        else if (comparacionFecha1 == 0)
        {
            Console.WriteLine("Es la misma fecha");
        }
        else
        {
            Console.WriteLine("La segunda fecha es anterior");
        }

        // Imprimir la fecha con formato
        Console.WriteLine(fecha1.ToString());
        Console.WriteLine(fecha1.ToShortDateString());     // Imprime fecha en formto corto
        Console.WriteLine(fecha1.ToLongDateString());      // Imprime fecha en fomrto extenso
        Console.WriteLine(fecha1.ToShortTimeString());     // Imprime tiempo en formato corto

        // Cambiando el formato sobreescribiendo el constructor método ToString() del tipo DateTime
        Console.WriteLine();
        Console.WriteLine(fecha1.ToString("d"));
        Console.WriteLine(fecha1.ToString("D"));
        Console.WriteLine(fecha1.ToString("t"));
        
        // Fecha con formato particular
        Console.WriteLine();
        Console.WriteLine(fecha1.ToString("yyyy-MM-ddThh:mm:ss.ms"));


        /*
        -------------------------------------------------------------------------------------------
        */

    }
}