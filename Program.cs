namespace PlayingCards
{
    internal class Program
    {
        private static readonly Random random = new Random();
        static void Main(string[] args)
        {
            int randomValue = random.Next(1,14);
            int randomSuit = random.Next(4);
            Card card = new Card((Values)randomValue, (Suits)randomSuit);
            Console.WriteLine(card.Name);
        }
    }
}