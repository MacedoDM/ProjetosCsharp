using System;
using System.Collections.Generic;
using System.Text;

namespace Esfera2
{
    class Dados
    {
        public static double Pi = 3.14;
        public static double Circunferencia(double raio)
        {
            return 2.0 * Pi * raio;
        }

        public static double Volume(double raio)
        {
            return 4 / 3 * Pi * raio * raio * raio;
        }
    }
}
