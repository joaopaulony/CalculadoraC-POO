using System;
using CalculadoraApp.Modelo; // Atualizando o namespace


namespace CalculadoraApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exibir mensagem inicial
            Console.WriteLine("Bem-vindo à Calculadora!");

            // Obter os números do usuário
            Console.Write("Digite o primeiro número: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            // Criar uma instância da calculadora
            Calculadora calculadora = new Calculadora(num1, num2);

            // Menu de operações
            Console.WriteLine("\nEscolha uma operação:");
            Console.WriteLine("1. Somar");
            Console.WriteLine("2. Subtrair");
            Console.WriteLine("3. Multiplicar");
            Console.WriteLine("4. Dividir");
            Console.Write("Sua escolha: ");
            int escolha = Convert.ToInt32(Console.ReadLine());

            try
            {
                // Executar a operação escolhida
                switch (escolha)
                {
                    case 1:
                        calculadora.Somar();
                        Console.WriteLine($"Resultado: {calculadora.GetResultado()}");
                        break;
                    case 2:
                        calculadora.Subtrair();
                        Console.WriteLine($"Resultado: {calculadora.GetResultado()}");
                        break;
                    case 3:
                        calculadora.Multiplicar();
                        Console.WriteLine($"Resultado: {calculadora.GetResultado()}");
                        break;
                    case 4:
                        calculadora.Dividir();
                        Console.WriteLine($"Resultado: {calculadora.GetResultado()}");
                        break;
                    default:
                        Console.WriteLine("Operação inválida.");
                        break;
                }
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"Erro: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro inesperado: {ex.Message}");
            }

            // Encerramento
            Console.WriteLine("\nObrigado por usar a Calculadora!");
        }
    }
}
