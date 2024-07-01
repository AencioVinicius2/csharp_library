using System;

namespace ExercicioDeFixacao.Entities
{
    class UsedProduct : Product
    {
        public DateTime ManufactureDate { get; set; }

        public UsedProduct(string nome, double price, DateTime manufactureDate) : base(nome, price)
        {
            ManufactureDate = manufactureDate;
        }

        public override string priceTag()
        {
            return base.priceTag() + $"(Manufacture date: {ManufactureDate})";
        }
    }
}
