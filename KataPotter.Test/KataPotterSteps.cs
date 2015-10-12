using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using TechTalk.SpecFlow;

namespace KataPotter.Test
{
    [Binding]
    public class KataPotterSteps
    {
        private KataPotterPriceCalculator calculator;

        private Dictionary<string, int> booksToBuy;

        private double totalPrice;

        public KataPotterSteps()
        {
            this.calculator = new KataPotterPriceCalculator();
            this.booksToBuy = new Dictionary<string, int>();
            this.totalPrice = 0d;
        }

        [Given(@"Buy ""(.*)"" copy of the first book")]
        public void GivenBuyCopyOfTheFirstBook(int count)
        {
            this.booksToBuy.Add("1", count);
        }
        
        [Given(@"Buy ""(.*)"" copy of the second book")]
        public void GivenBuyCopyOfTheSecondBook(int count)
        {
            this.booksToBuy.Add("2", count);
        }
        
        [Given(@"Buy ""(.*)"" copy of the third book")]
        public void GivenBuyCopyOfTheThirdBook(int count)
        {
            this.booksToBuy.Add("3", count);
        }
        
        [Given(@"Buy ""(.*)"" copy of the fourth book")]
        public void GivenBuyCopyOfTheFourthBook(int count)
        {
            this.booksToBuy.Add("4", count);
        }
        
        [Given(@"Buy ""(.*)"" copy of the fifth book")]
        public void GivenBuyCopyOfTheFifthBook(int count)
        {
            this.booksToBuy.Add("5", count);
        }
        
        [When(@"Calculate total price")]
        public void WhenCalculateTotalPrice()
        {
            this.totalPrice = this.calculator.Calculate(this.booksToBuy);
        }
        
        [Then(@"Total price should be ""(.*)"" EUR\.")]
        public void ThenTotalPriceShouldBeEUR_(double price)
        {
            Assert.AreEqual(price, this.totalPrice);
        }
    }
}
