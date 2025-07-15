using Exercicio.Entities;
using System;

namespace Course.Entities
{
    class OutsourcedEmployee : Employee
    {
        public double AdditonalCharge { get; set; }

        public OutsourcedEmployee() { }

        public OutsourcedEmployee(string name, int hours, double valuePerHour, double additonalCharge) : base(name, hours, valuePerHour)
        {
            AdditonalCharge = additonalCharge;
        }

        public override double Payment()
        {
            return base.Payment() + 1.1 * AdditonalCharge;
        }
    }
}
