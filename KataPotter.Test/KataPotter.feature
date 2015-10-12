Feature: KataPotter's Total Price Calculator
	Potter mania is sweeping the country and parents of teenagers everywhere are queueing up 
	with shopping baskets overflowing with Potter books. Your mission is to write a piece of 
	code to calculate the price of any conceivable shopping basket, giving as big a discount 
	as possible.

	Rule: 
		1. One copy of any of the five books costs 8 EUR. 
		2. If, however, you buy two different books from the series, you get a 5% discount on 
		   those two books. 
		3. If you buy 3 different books, you get a 10% discount. 
		4. With 4 different books, you get a 20% discount. 
		5. If you go the whole hog, and buy all 5, you get a huge 25% discount.
		
Scenario: Buy only 1 copy of the first book. Total price should be 8 EUR.
	Given Buy "1" copy of the first book
	And   Buy "0" copy of the second book
	And   Buy "0" copy of the third book
	And   Buy "0" copy of the fourth book
	And   Buy "0" copy of the fifth book
	When Calculate total price
	Then Total price should be "8" EUR.