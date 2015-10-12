using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataPotter
{
    public class KataPotterPriceCalculator
    {
        private static readonly double BOOK_UNIT_PRICE = 8;

        public double Calculate(Dictionary<string, int> booksToBuy)
        {
            var totalCount = booksToBuy.Sum(i => i.Value);
            var totalPrice = totalCount * BOOK_UNIT_PRICE;

            return totalPrice;
        }
    }
}
