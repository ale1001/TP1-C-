using System;

namespace Divi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Essa calculadora calcula a divisão entre 2 números!");
            int n1, n2, resultado;
            Console.WriteLine("Informe o primeiro número:");
            n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o segundo número;");
            n2 = int.Parse(Console.ReadLine());

            resultado = n1 / n2;

            Console.WriteLine("O resultado entre a divisão do número " + n1 + " e " + n2 + ", é: " + resultado);
            Console.ReadKey();
        }
    }
    }

