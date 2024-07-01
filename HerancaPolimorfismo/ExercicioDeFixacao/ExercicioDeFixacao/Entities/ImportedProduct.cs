using System
using System.Globalization;
using ExercicioDeFixacao.Entities;

namespace ExercicioDeFixacao.Entities
{
    class ImportedProduct : Product
    {
        public double CustomsFee { get; set; }
        ImportedProduct(string nome, double price, double customsFee ) : base(nome, price)
        {
            CustomsFee = customsFee;
        }

        public override string priceTag()
        {
            return base.priceTag() + $"(Customs fee: {CustomsFee.ToString("F2",CultureInfo.InvariantCulture)})";
        }

        public double totalPrice()
        {
            return CustomsFee + Price;
        }
    }
}
