using System;

namespace ExercicioDeFixacao.Entities
{
    class UsedProduct : Product
    {
        public DateTime ManufactureDate { get; set; }

        public UsedProduct ()
        {

        }

        public UsedProduct(string nome, double price, DateTime manufactureDate) : base(nome, price)
        {
            ManufactureDate = manufactureDate;
        }

        public override string priceTag()
        {
            return base.priceTag() + $"(Manufacture date: {ManufactureDate})";
        }

        public override string ToString()
        {
            return "Name: "
                        + Name
                        + Environment.NewLine
                        + "Price: "
                        + Price
                        + Environment.NewLine
                        + "Manufacture Date (DD/MM/YYYY): "
                        + ManufactureDate;
        }
    }
}
