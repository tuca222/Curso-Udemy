using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioProdutos.Entities
{
    class ImportedProduct : Product
    {
        public double CustomsFee { get; private set; }

        public ImportedProduct()
        {
        }

        public ImportedProduct(string name, double price, double customsFee) 
            :base(name, price)
        {
            CustomsFee = customsFee;
        }

        public sealed override string PriceTag()
        {
            return Name + " R$ " + TotalPrice().ToString("F2", CultureInfo.InvariantCulture) + " (Customs Fee: " + CustomsFee.ToString("F2", CultureInfo.InvariantCulture) + ")";
        }

        public double TotalPrice()
        {
            return Price + CustomsFee;
        }
    }
    
}
