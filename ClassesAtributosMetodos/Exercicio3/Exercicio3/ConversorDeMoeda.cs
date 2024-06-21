using System;
using System.Globalization;

namespace Course
{
    static class ConversorDeMoeda
    {

    static double Iof = 0.06; 

    public static double DolarParaReal(double valorComprado, double cotacaoDoDolar)
        {
            return cotacaoDoDolar * (valorComprado * Iof);
        }
    }
}
