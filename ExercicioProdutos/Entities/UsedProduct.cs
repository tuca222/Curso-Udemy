using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioProdutos.Entities
{
    class UsedProduct : Product
    {
        public DateTime ManufactureDate { get; private set; }

        public UsedProduct()
        {
        }

        public UsedProduct(string name, double price, DateTime manufactureDate)
            : base(name, price)
        {
            ManufactureDate = manufactureDate;
        }

        public sealed override string PriceTag()
        {
            return Name + " (Used) R$ " + Price.ToString("F2", CultureInfo.InvariantCulture) + $" (Manufacture date: {ManufactureDate.ToString("dd/MM/yyyy")})";
        }
    }
}
