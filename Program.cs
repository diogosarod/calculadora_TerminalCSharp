using System;

namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {
                RealizarOperacao();

                Console.WriteLine("Deseja fazer outra operação? Use (s/n)");
            } while (Console.ReadLine().ToLower() == "s");

            Console.WriteLine("Agradeço pelo tempo disponibilizado. Aperte a tecla 'Enter' para sair.");
            Console.ReadLine();
        }

        static void RealizarOperacao()
        {
            Console.WriteLine("Qual operação deseja fazer? (Escolha de 1 ao 4) ");
            Console.WriteLine("1 - Adição");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão ");

            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    RealizarAdicao();
                    break;
                case "2":
                    RealizarSubtracao();
                    break;
                case "3":
                    RealizarMultiplicacao();
                    break;
                case "4":
                    RealizarDivisao();
                    break;
                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }
        }

        static void RealizarAdicao()
        {
            Console.WriteLine("Digite o primeiro número: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o segundo número: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            double resultado = num1 + num2;
            Console.WriteLine($"Resultado: {resultado}");
        }

        static void RealizarSubtracao()
        {
            Console.WriteLine("Digite o primeiro número: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o segundo número: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            double resultado = num1 - num2;
            Console.WriteLine($"Resultado: {resultado}");
        }

        static void RealizarMultiplicacao()
        {
            Console.WriteLine("Digite o primeiro número: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o segundo número: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            double resultado = num1 * num2;
            Console.WriteLine($"Resultado: {resultado}");
        }

        static void RealizarDivisao()
        {
            Console.WriteLine("Digite o primeiro número: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o segundo número: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            if (num2 != 0)
            {
                double resultado = num1 / num2;
                Console.WriteLine($"Resultado: {resultado}");
            }
            else
            {
                Console.WriteLine("Erro: Divisão por zero.");
            }
        }
    }
}
