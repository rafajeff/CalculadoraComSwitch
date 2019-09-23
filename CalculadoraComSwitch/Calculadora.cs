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
        public static double Somar(double n1, double n2)
        {
            return  n1 + n2;
        }
        public static double Subtrai(double n1, double n2)
        {
            return n1 - n2;
        }

        public static double Dividir(double n1, double n2)
        {
            return n1 / n2;
        }
        public static double Multiplicar(double n1, double n2)
        {
            return n1* n2;
        }
    }
}
