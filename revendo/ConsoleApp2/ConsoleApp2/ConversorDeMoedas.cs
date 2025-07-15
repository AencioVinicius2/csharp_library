using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class ConversorDeMoedas
    {
        static public int Iof = 6;
        

        static public double CalculaConversao(double dolares, double cotDoll)
        {
            return (dolares * cotDoll) + (dolares * cotDoll) * 0.06;
        }
    }
}
