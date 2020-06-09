using System;
using CA_Sobrecarga_Potencia.Model;

namespace CA_Sobrecarga_Potencia
{
    class Program
    {
        static void Main(string[] args)
        {
            Potencia pot1 = new Potencia();

            System.Console.Write("Digite um número: ");
            int valor1 = Convert.ToInt32(Console.ReadLine());
            double result1 = pot1.CalcularPot(valor1);
            System.Console.WriteLine($"Potencia de {valor1} por {valor1} é {result1}");

            System.Console.Write("Digite o número base: ");
            int basee = Convert.ToInt32(Console.ReadLine());
            System.Console.Write("Digite o número da potencia: ");
            int potencia = Convert.ToInt32(Console.ReadLine());
            double result2 = pot1.CalcularPot(basee, potencia);

            System.Console.WriteLine($"Potencia de {basee} por {potencia} é {result2}");
            
            Console.ReadKey();
        }
    }
}
