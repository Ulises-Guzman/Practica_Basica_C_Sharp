internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

		try
		{
			Console.WriteLine("Ingrese un número: ");
			int numero = int.Parse(Console.ReadLine()!);
			Console.WriteLine("Ingrese un número divisor: ");
			int divisor = int.Parse(Console.ReadLine()!);
			int resultado = numero / divisor;
			Console.WriteLine($"El resultador es: {resultado}");
		}
		catch (FormatException e)
		{
			Console.WriteLine("> Error: El texto introducido no fue un número entero.");
		}
		catch (DivideByZeroException e)
		{
			Console.WriteLine("> Error: No es posible dividir por cero.");
		}
		catch (Exception e)
		{
			Console.WriteLine($"> Se ha producido un error: {e.Message.ToString()}");
		}
    }
}