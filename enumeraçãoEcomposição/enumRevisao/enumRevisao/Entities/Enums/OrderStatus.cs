using System;

namespace Course.Entities.Enums
{
    enum OrderStatus : int
    {
        PendingPayment = 8,
        Processing = 1,
        Shipped = 2,
        Delivered = 3   
    }
}
