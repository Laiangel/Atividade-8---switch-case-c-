using System;

namespace atividade8
{
    class Program
    {
        static void Main()
        {
            
            Console.WriteLine("Escolha a conversão:");
            Console.WriteLine("1 - Celsius para Fahrenheit");
            Console.WriteLine("2 - Fahrenheit para Celsius");

           
            Console.Write("Digite sua escolha (1 ou 2): ");
            if (!int.TryParse(Console.ReadLine(), out int opcao) || (opcao != 1 && opcao != 2))
            {
                Console.WriteLine("Opção inválida. Por favor, escolha 1 ou 2.");
                return;
            }

         
            Console.Write("Digite a temperatura: ");
            if (!double.TryParse(Console.ReadLine(), out double temperatura))
            {
                Console.WriteLine("Entrada inválida. Por favor, insira um número válido.");
                return;
            }

          
            if (opcao == 1) 
            {
                double fahrenheit = (temperatura * 9 / 5) + 32;
                Console.WriteLine($"{temperatura}°C é igual a {fahrenheit}°F.");
            }
            else if (opcao == 2) 
            {
                double celsius = (temperatura - 32) * 5 / 9;
                Console.WriteLine($"{temperatura}°F é igual a {celsius}°C.");
            }
        }
    }
}

