internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("- Ingrese un número para calcular su factorial: ");
        int numeroIngresado = int.Parse(Console.ReadLine()!);
        Factorial(numeroIngresado);
    }

    public static int Factorial(int numero)
    {
        int i, resultado = 1;
        for (i = 1; i <= numero; i++)
        {
            resultado = resultado * i;
            Console.WriteLine(resultado);
        }
        return resultado;
    }
}