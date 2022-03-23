using System;

namespace FidayNightRandom
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplayRandomFood();
            DisplayRandomDrink();
            DisplayRandomMovie();
        }

        private static int GenerateRandomIndex(string[] someArray)
        {
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, someArray.Length);

            return randomIndex;
        }

        private static void DisplayRandomFood()
        {
            string[] foods = { "popcorn", "sushi", "chicken wings", "pizza", "burger and fries" };

            Console.WriteLine($"Computer picked:{foods[GenerateRandomIndex(foods)]}");
        }

        private static void DisplayRandomDrink()
        {
            string[] drinks = { "apple juice", "coke", "fanta", "sprite" };
            
            Console.WriteLine($"Computer picked:{drinks[GenerateRandomIndex(drinks)]}");
        }
        private static void DisplayRandomMovie()
        {
            string[] movie = { "Top Gun", "Rambo", "Fast and Furious Franchise", "Pirates of the Carribean", "JOKER" };
            
            Console.WriteLine($"Computer picked:{movie[GenerateRandomIndex(movie)]}");
        }

    }
}
