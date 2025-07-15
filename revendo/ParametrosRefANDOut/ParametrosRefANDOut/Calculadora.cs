using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParametrosRefANDOut
{
    
    class Calculadora
    {
        public static void Triple(ref int x, out int result)
        {
            // modificando o valor original
            result = x * 3;

            // result passa a apontar para triple (logo, triple tera o valor de result)
            // ref e out sao similares, a diferença é que ref obrigado o usuario a passar um valor inicial, diferente de out, que nao precisa. ambos são "code smells"
        }
    }
}
