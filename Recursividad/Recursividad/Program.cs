internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("- Ingrese un número para calcular su factorial: ");
        int numeroIngresado = Console.ReadLine();
        Factorial(numeroIngresado);
    }

    public static int Factorial(int numero)
    {
        int i, resultado = 1;
        for (i = 1; i <= numero; i++)
        {
            resultado = resultado * i;
        }
        return resultado;
    }
}