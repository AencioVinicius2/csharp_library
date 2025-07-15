using Course.Entities;
using Course.Entities.Enums;
using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order {
                Id = 1080,
                Moment = DateTime.Now,
                Status = Orderstatus.PendingPayment,
            };

            Console.WriteLine(order);

            string txt = Orderstatus.PendingPayment.ToString();

            Orderstatus os = Enum.Parse<Orderstatus>("Delivered");


            Console.WriteLine(txt);
        }
    }
}