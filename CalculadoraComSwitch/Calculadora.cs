using System;
using System.Collections.Generic;
using System.Text;

namespace Calculadora
{
    static class Operacoes
        
    {
        /// <summary>
        /// Soma dois números
        /// </summary>
        /// <param name="n1">Número 1</param>
        /// <param name="n2">Numéro 2</param>
        /// <returns>Retorna a soma de dois números</returns>
        public static int Somar(int n1, int n2)
        {
            return n1 + n2;
        }
        public static int Subtrai(int n1, int n2)
        {
            return n1 - n2;
        }

        public static int Dividir(int n1, int n2)
        {
            return n1 / n2;
        }
        public static int Multiplicar(int n1, int n2)
        {
            return n1 * n2;
        }
    }
}
