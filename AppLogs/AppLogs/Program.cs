/*
    - Crear un aplicación que realice el registro de losg, en un fichero,
cada vez que se imprima por pantalla.}
    - El formato del log es:
Fecha del log: {diaSemana}, {numeroDiaMes}, de {mesConNombre} del {año}
    - Introducir por patalla una fecha en formato año, mes, dia y mostrar por pantalla.
*/
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

internal class Program
{
    //static string path = @"C:\Users\sysadmin\Documents\FicherosLogs_AppLogs\logs_fecha.log";
    static string path = @"C:\Users\sysadmin\Documents\FicherosLogs_AppLogs\logs_login.log";
    private static void Main(string[] args)
    {
        /*
        Console.WriteLine("Ingrese un fecha con formato ddMMyyyy");
        string fechaIntroducida = Console.ReadLine()!;
        var fecha = DateTime.ParseExact(fechaIntroducida, "ddMMyyyy", new CultureInfo("es-AR"));

        string mensaje = $"{fecha.ToString("dddd")} {fecha.Day} de {fecha.ToString("MMMM")} del año {fecha.Year}";
        Console.WriteLine(mensaje);
        string log = $"{fecha.Day}-{fecha.Month}-{fecha.Year}T{fecha.TimeOfDay}";

        RegistroLogs(log);
        */

        Console.Write("Ingrese usuario: ");
        string usuario = Console.ReadLine()!;
        Console.Write("Ingrese clave: ");
        string clave = Console.ReadLine()!;
        DateTime dateTime = DateTime.Now;
        string regLog = $"{dateTime.ToString("dd-MM-yy")} T {dateTime.ToString("HH:mm:ss")} U {usuario}";

        LoginLog(usuario, clave, regLog);
    }

    public static void RegistroLogs(string regLog)
    {
        if (!File.Exists(path))
        {
            using (StreamWriter fichero = File.CreateText(path)) { }
        }

        File.AppendAllLines(path, new List<string> { regLog });
    }

    public static void LoginLog(string usuario, string clave, string regLog)
    {
        if (usuario != "" && clave != "")
        {
            Console.WriteLine("Login Satisfactorio...");

            if (!File.Exists(path))
            {
                using (StreamWriter ficheroWriter = new StreamWriter(path)) { }
            }

            File.AppendAllLines(path, new List<string> { regLog });
        }
        else
            Console.WriteLine("Complete los campos...");
    }
}