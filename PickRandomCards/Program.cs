namespace PickRandomCards
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number of cards to pick: ");
            string line = Console.ReadLine();
            if (int.TryParse(line, out int numberOfCards))
            {
                string [] setOfCards = CardPicker.PickSomeCards(numberOfCards);
                foreach (string singleCard in setOfCards)
                {
                    Console.WriteLine(singleCard);
                }
            }
            else 
            {
                Console.WriteLine("your entered value is not a valid number");
            }
        }
    }
}
