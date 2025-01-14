internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        using (StreamReader reader = new StreamReader(@"C:\Users\sysadmin\Documents\FicherosProyecto\dir1.txt"))
        {
            // Leer Fichero
            /*
            string texto;
            while ((texto = reader.ReadLine()!) != null)
            {
                Console.WriteLine(texto);
            }
            */
        }

        // Escribir Fichero
        string[] ciudades = new string[] { "Punta Alta", "Bahia Blanca", "Mar del PLata", "La Plata" };
        string ciudad5 = "Monte Hermoso";

        using (StreamWriter writer = new StreamWriter(@"C:\Users\sysadmin\Documents\FicherosProyecto\ciudades.txt"))
        {
            foreach (string ciudad in ciudades)
            {
                writer.WriteLine(ciudad);
            }
        }

        //using (StreamReader readerCiudades = new StreamReader(@"C:\Users\sysadmin\Documents\FicherosProyecto\ciudades.txt"))
        //{
        //    string readTexto;
        //    while ((readTexto = readerCiudades.ReadLine()!) != null)
        //    {

        //    }

        //}

        //using (StreamWriter writer = new StreamWriter(@"C:\Users\sysadmin\Documents\FicherosProyecto\ciudades.txt"))
        //{
        //    writer.WriteLine(ciudad5);
        //}


        using (StreamWriter writer = new StreamWriter(@"C:\Users\sysadmin\Documents\FicherosProyecto\ciudades.txt"))
        {
            foreach (string ciudad in ciudades)
            {
                writer.WriteLine(ciudad);
            }
            writer.WriteLine(ciudad5);
        }

        // Clase File
        // Lee todo el fichero de una
        string fileReader = File.ReadAllText(@"C:\Users\sysadmin\Documents\FicherosProyecto\ciudades.txt");
        Console.WriteLine(fileReader);
        Console.WriteLine();

        // Lee línea por línea
        string[] fileReader1 = File.ReadAllLines(@"C:\Users\sysadmin\Documents\FicherosProyecto\ciudades.txt");
        foreach (string line in fileReader1)
        {
            Console.WriteLine(line);
        }

        // Escribe línea por línea, todas las líneas, por ejemplo desde un array
        string[] ciudades2 = ["Paraná", "Santa Rosa", "Rio Cuarto", "Neuquen"];
        File.WriteAllLines(@"C:\Users\sysadmin\Documents\FicherosProyecto\ciudades2.txt", ciudades2);

        // Escribe, vuelca todo el texto en el fichero, pisa todo el contenido
        //File.WriteAllText(@"C:\Users\sysadmin\Documents\FicherosProyecto\ciudades3.txt", "> Más texto...");

        // Lee el fichero línea por línea
        string[] fileReader2 = File.ReadAllLines(@"C:\Users\sysadmin\Documents\FicherosProyecto\ciudades2.txt");
        foreach (string line in fileReader2)
        {
            Console.WriteLine(line);
        } 
        Console.WriteLine();

        // Agrega una línea al fichero, sin pisar todo el contenido. Utilizar \n para dar el salto de línea.
        File.AppendAllText(@"C:\Users\sysadmin\Documents\FicherosProyecto\ciudades3.txt", "\n" + "Hola Mundo!");
        string fileReader3 = File.ReadAllText(@"C:\Users\sysadmin\Documents\FicherosProyecto\ciudades3.txt");
        Console.WriteLine(fileReader3);
         
    }
}