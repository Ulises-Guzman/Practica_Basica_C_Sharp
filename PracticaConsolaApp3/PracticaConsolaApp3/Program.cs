using PracticaConsolaApp3;
using System.Security.Cryptography.X509Certificates;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        Moto moto1 = new Moto("Honda", "XR", 250, 21);
        Moto moto2 = new Moto("Ducatti", "A1", 250, 20);
        Auto auto1 = new Auto("Chevrolet", "Agile");
        Console.WriteLine(moto1.Marca);
        Console.WriteLine(moto2.Marca);
        Console.WriteLine(auto1.Marca);
        moto1.Arrancar();

    } 
}