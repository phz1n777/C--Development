using System;

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade1, idade2;
            Console.WriteLine("Insira a idade do aluno 1:");
            idade1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira a idade do aluno 2:");
            idade2 = int.Parse(Console.ReadLine());

            if (idade1 == idade2)
            {
                Console.WriteLine("Os dois alunos tem a mesma idade.");
            }

            if (idade1 > idade2)
            {
                Console.WriteLine("O aluno 1 é mais velho e o aluno 2 é mais novo.");
            }

            if (idade1 < idade2)
            {
                Console.WriteLine("O aluno 1 é mais novo e o aluno 2 é mais velho.");
            }
        }
    }
}