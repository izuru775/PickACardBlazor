using System;
namespace PickACardBlazor
{
    public class CardPicker
    {
        // Creating a random number generator
        static Random random = new Random();

        public static string[] PickSomeCards(int numberOfCards)
        {
            string[] pickedCards = new string[numberOfCards];
            for(int i = 0; i < numberOfCards; i++)
            {
                pickedCards[i] = RandomValue() + " of " + RandomSuit();
            }
            return pickedCards;
        }

        private static string RandomSuit()
        {
            // Get a random number from 1 to 4
            int value = random.Next(1,5);
            // If it's 1 return the string Spades
            if (value == 1) return "Spades";
            // If it's 2 return the string Hearts
            if (value == 2) return "Hearts";
            // If it's 3 return the string Clubs'
            if (value == 3) return "Clubs";
            // If we haven't returned yet.return the string Diamonds
            return "Diamonds";
        }

        private static string RandomValue()
        {
            int value = random.Next(1,14);
            if (value == 1) return "Ace";
            if (value == 11) return "Jack";
            if (value == 12) return "Queen";
            if (value == 13) return "King";
            return value.ToString();
        }
    }
}
