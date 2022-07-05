using System;
using System.Collections.Generic;
using System.Text;

namespace CompraDeDolares
{
    class Dados
    {
        public static double IOF = 0.06;
        public static double Conversao(double Cotacao, double Valor)
        {
            double total = Cotacao * Valor;
            return total + total * IOF;
        }
    }
}
