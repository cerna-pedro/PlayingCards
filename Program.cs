using System.Collections.Generic;

namespace PlayingCards
{
    internal class Program
    {
        private static readonly Random random = new Random();

        private static Card RandomCard()
        {
            int randomValue = random.Next(1, 14);
            int randomSuit = random.Next(4);
            Card card = new Card((Values)randomValue, (Suits)randomSuit);
            return card;

        }

        private static void PrintCard(List<Card> cards)
        {
            foreach (Card card in cards)
            {
                Console.WriteLine(card.Name);
            }
        }
        static void Main(string[] args)
        {
            List<Card> cardsList = new List<Card>();
            Console.Write("Enter number of cards: ");
            string userInput = Console.ReadLine();
            if (int.TryParse(userInput, out int numberOfCards)) 
            {
                for (int i = 0; i < numberOfCards; i++)
                {
                    cardsList.Add(RandomCard());

                }
                PrintCard(cardsList);

                Console.WriteLine("\n... sorting the cards...\n");

                IComparer<Card> comparer = new CardComparerByValue();

                cardsList.Sort(comparer);

                PrintCard(cardsList);

            }
            
        }
    }
}