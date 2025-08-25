using System;

namespace AreaCalculator
{
    class Program
    {
        static void Print(string mensagem)
        {
            Console.WriteLine(mensagem);
        }

        static void Print(double valor)
        {
            Console.WriteLine("Resultado: " + valor);
        }
       
        static double Area(double raio) 
        {
            return Math.PI * raio * raio;
        }

        static double Area(double baseTriangulo, double altura) 
        {
            return (baseTriangulo * altura) / 2;
        }

        static double Area(double comprimento, double largura, bool isRetangulo) 
        {
            return comprimento * largura;
        }

        static void Main(string[] args)
        {
            Print("Bem-vindo ao Calculador de Áreas!");
            Print("Qual é o seu nome?");
            string nome = Console.ReadLine();

            Print($"Olá, {nome}! Vamos calcular áreas de figuras geométricas.");
            Print("Escolha uma opção:");
            Print("1 - Círculo");
            Print("2 - Triângulo");
            Print("3 - Retângulo");

            int escolha = int.Parse(Console.ReadLine());

            double resultado = 0;

            if (escolha == 1) 
            {
                Print("Digite o raio do círculo:");
                double raio = double.Parse(Console.ReadLine());
                resultado = Area(raio);
            }
            else if (escolha == 2) 
            {
                Print("Digite a base do triângulo:");
                double baseTri = double.Parse(Console.ReadLine());
                Print("Digite a altura do triângulo:");
                double altura = double.Parse(Console.ReadLine());
                resultado = Area(baseTri, altura);
            }
            else if (escolha == 3) 
            {
                Print("Digite o comprimento do retângulo:");
                double comprimento = double.Parse(Console.ReadLine());
                Print("Digite a largura do retângulo:");
                double largura = double.Parse(Console.ReadLine());
                resultado = Area(comprimento, largura, true);
            }
            else
            {
                Print("Opção inválida!");
            }

            if (resultado > 0)
            {
                Print($"A área calculada é: {resultado:F2}");
            }
        }
    }
}
