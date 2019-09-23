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
                    resultado = Calculadora.Operacoes.Somar(n1, n2);
                    Console.WriteLine($"A soma de {n1} + {n2} é: {resultado}");
                    break;

                case "-":
                    resultado = Calculadora.Operacoes.Subtrai(n1, n2);
                    Console.WriteLine($"A Subtração de {n1} - {n2} é: {resultado}");
                    break;

                case "/":
                    resultado = Calculadora.Operacoes.Dividir(n1, n2);
                    Console.WriteLine($"A Divisão de {n1} / {n2} é: {resultado}");
                    break;

                case "*":
                    resultado = Calculadora.Operacoes.Multiplicar(n1, n2);
                    Console.WriteLine($"A Multiplicação de {n1} * {n2} é: {resultado}");

                  default:
                    Console.WriteLine("Operação Inválida");
                    break;
                    
                   
                    
                    
            }


        }
    }
}
