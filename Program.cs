using System;
using System.Collections.Generic; 

namespace AllCardsOnDeckCS
{ 
  
  class Program
  {
    static void Main(string[] args)
    {
     var cardValue = new List<string>(){"Ace of spade", "Two of spade", "Three of spade", "Four of spade", "Five of spade", "Six of spade", "Seven of spade", "Eight of spade", "Nine of spade", "Ten of spade", "Jack of spade", "Queen of spade", "King of spade",
      "Ace of club", "Two of club", "Three of club", "Four of club", "Five of club", "Six of club", "Seven of club", "Eight of club", "Nine of club", "Ten of club", "Jack of club", "Queen of club", "King of club", 
      "Ace of heart", "Two of heart", "Three of heart", "Four of heart", "Five of heart", "Six of heart", "Seven of heart", "Eight of heart", "Nine of heart", "Ten of heart", "Jack of heart", "Queen of heart", "King of heart", 
      "Ace of diamond", "Two of diamond", "Three of diamond", "Four of diamond", "Five of diamond", "Six of  diamond", "Seven of diamond", "Eight of diamond", "Nine of diamond", "Ten of diamond", "Jack of diamond", "Queen of diamond", "King of diamond"};

    var sizeOfDeck = cardValue.Count;
    for (var endOfDeck = sizeOfDeck-1; endOfDeck >=0; endOfDeck--)
    {
      var randomNumberForDeck = new Random().Next(0,sizeOfDeck);
      var randomCardWithinDeck = cardValue[randomNumberForDeck];
      cardValue[randomNumberForDeck] = cardValue[endOfDeck]; 
      cardValue[endOfDeck] = randomCardWithinDeck;
    }
    Console.WriteLine(cardValue[0]);
    Console.WriteLine(cardValue[1]);
    
  
     

    }

  }
}
