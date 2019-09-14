using System;
using System.Collections.Generic;
using System.Linq;

namespace CsharpPoker
{
    public class Hand
    {
        private List<Card> cards = new List<Card>();

        // To limit mutablility of the Cards property, an IEnumerable is returned instead of List
        // Cards is mutable but only by calling Draw
        public IEnumerable<Card> Cards => cards;

        public void Draw(Card card) => cards.Add(card);
        


        public Card HighCard() => cards.Aggregate((highCard, nextCard) => nextCard.Value > highCard.Value ? nextCard : highCard);
       

        public HandRank GetHandRank() =>        
            HasRoyalFlush() ? HandRank.RoyalFlush :
            HasFlush() ? HandRank.Flush :
            HandRank.HighCard;
        
        private bool HasFlush() => cards.All(c => cards.First().Suit == c.Suit);        

        private bool HasRoyalFlush() => HasFlush() && cards.All(c => c.Value > CardValue.Nine);
        
        
    }
}