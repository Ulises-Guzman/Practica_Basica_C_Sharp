using System.Drawing;
using System.Security.Cryptography.X509Certificates;

internal class Program
{
    private static void Main(string[] args)
    {     
        int valorOriginal = 0;
        int valorNull;

        ActualizarValor(valorOriginal);
        Console.WriteLine($"> Valor original sin modificar es: {valorOriginal}");
        ActualizarReferencia(ref valorOriginal);
        Console.WriteLine($"> Valor original Modificado por referencia es: {valorOriginal}");
        ActualizarReferencia1(out valorNull);
        Console.WriteLine($"> Valor original Modificado e Inicializado por referencia es: {valorNull}");

        int referente = 22;
        ActualizarReferencia2(in referente);
        
        ObjetoEjemplo NumeroObjeto = new ObjetoEjemplo(33);
        Console.WriteLine($"> El valor de la property del objeto Ejemplo es : {NumeroObjeto.Entero}");
    }

    // Pasaje por valor
    public static void ActualizarValor(int valorActualizar)
    {
        valorActualizar += 5;
        Console.WriteLine($"> El valor modificado dentro del método es: {valorActualizar}");
    }

    // Pasaje por referencia ref
    public static void ActualizarReferencia( ref int valorActuaizarRef)
    {
        valorActuaizarRef += 5;
        Console.WriteLine($" > El valor modificado por referncia, en el método, es: {valorActuaizarRef}");
    }

    // Pasaje por referencia out
    public static void ActualizarReferencia1(out int valorInicializar)
    {
        valorInicializar = 11;
    }

    // Pasaje por referencia in
    // ...Caso en el cual no queremos que cierta variable sea modificada.
    public static void ActualizarReferencia2(in int valorNoModificable)
    {
        int referente = valorNoModificable;
        Console.WriteLine($"> Valor no modificable, por ejemplo, un referente: {referente}");
    }

    // Pasaje de objeto
    // Creo una clase para luego hacer refernciar e instanciar un objeto.
    // Luego creo la funcion que recibe al objeto.

    public class ObjetoEjemplo
    {
        public int Entero { get; set; }

        public ObjetoEjemplo(int entero)
        {
            Entero = entero;
        }
    }
}