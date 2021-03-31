using Enumeracoes.Entities;
using Enumeracoes.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumeracoes
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order
            {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };
            Console.WriteLine(order);

            string txt = OrderStatus.PendingPayment.ToString();
            Console.WriteLine(txt);

            OrderStatus os = (OrderStatus)Enum.Parse(typeof(OrderStatus), "Delivered"); // Convertendo string "Delivered" para Enum
            Console.WriteLine(os);



            Console.ReadLine();
        }
    }
}
