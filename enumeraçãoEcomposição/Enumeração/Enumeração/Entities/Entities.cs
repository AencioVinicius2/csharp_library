using System;
using Course.Entities.Enums;

namespace Course.Entities
{
    class Order
    {
        public int Id { get; set; }
        public DateTime Moment { get; set; }
        public Orderstatus Status { get; set; }

        public override string ToString()
        {
            return Id
                   + ", "
                   + Moment
                   + ", "
                   + Status;
        }
    }
}
