<<<<<<< HEAD
﻿using System;
=======
﻿    using System;
>>>>>>> fbe3fe36632066f25a40b035fbfc8f96c0007e05
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp1
{
    class Triangulo
    {

        public double A;
        public double B;
        public double C;

        public double Area()
        {
            double p = (A + B + C) / 2.0;

            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }
    }
}
