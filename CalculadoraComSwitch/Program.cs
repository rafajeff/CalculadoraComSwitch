using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            string op;
            int n1, n2, resultado;

            Console.WriteLine("Digite a operação que deseja realizar");
            op = Console.ReadLine();
            Console.WriteLine("Digite o primeiro numero");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero");
            n2 = int.Parse(Console.ReadLine());

            switch (op)
            {
                case "+":
                    resultado = Calculadora.Somar(n1, n2);
                    Console.WriteLine($"A soma de {n1} + {n2} é: {resultado}");
                    break;

                default:
                    Console.WriteLine("Operação Inválida");
                    break;
            }


        }
    }
}
