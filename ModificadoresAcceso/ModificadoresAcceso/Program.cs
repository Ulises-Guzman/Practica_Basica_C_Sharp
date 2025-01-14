
using ModificadoresAcceso;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        AccesoPublico accesoPublico = new AccesoPublico();
        Console.WriteLine(accesoPublico.AccPublico);
        accesoPublico.AccPublico1();

        AccesoPrivado accesoPrivado = new AccesoPrivado();
       //accesoPrivado.Ordenar(); // No es accesible
        
    }
}