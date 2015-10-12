using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataPotter
{
    public class KataPotterPriceCalculator
    {
        private static readonly decimal BOOK_UNIT_PRICE = 8;

        private static readonly decimal TWO_BOOKS_DISCOUNT_RATE = 0.95M;

        private static readonly decimal THREE_BOOKS_DISCOUNT_RATE = 0.9M;

        private static readonly decimal FOUR_BOOKS_DISCOUNT_RATE = 0.8M;

        private static readonly decimal FIVE_BOOKS_DISCOUNT_RATE = 0.75M;

        public decimal Calculate(Dictionary<string, int> booksToBuy)
        {
            var totalCount = booksToBuy.Sum(i => i.Value);
            var totalPrice = totalCount * BOOK_UNIT_PRICE;

            if (totalCount >= 5)
            {
                totalPrice = totalPrice * FIVE_BOOKS_DISCOUNT_RATE;
            }
            else if (totalCount >= 4)
            {
                totalPrice = totalPrice * FOUR_BOOKS_DISCOUNT_RATE;
            }
            else if (totalCount >= 3)
            {
                totalPrice = totalPrice * THREE_BOOKS_DISCOUNT_RATE;
            }
            else if (totalCount >= 2)
            {
                totalPrice = totalPrice * TWO_BOOKS_DISCOUNT_RATE;
            }

            return totalPrice;
        }
    }
}
