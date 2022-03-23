using System;

namespace FridayNightRandomReturn
{
    class Program
    {
        static void Main(string[] args)
        {
            string randomFood, randomDrink, randomMovie;
            string[] foods = { "popcorn", "sushi", "chicken wings", "pizza", "burger and fries" };
            string[] drinks = { "apple juice", "coke", "fanta", "sprite" };
            string[] movie = { "Top Gun", "Rambo", "Fast and Furious Franchise", "Pirates of the Carribean", "JOKER" };

            randomFood = PickRandomElementFromArray(foods);
            randomDrink = PickRandomElementFromArray(drinks);
            randomMovie = PickRandomElementFromArray(movie);

            Console.WriteLine($"Tonight you will have some {randomFood} with {randomDrink} and watch {randomMovie} ");

        }

        private static int GenerateRandomIndex(string[] someArray)
        {
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, someArray.Length);
            return randomIndex;
        }

        private static string PickRandomElementFromArray(string[] someArray)
        {
            string randomElement = someArray[GenerateRandomIndex(someArray)];
            return randomElement; 
        }
    }
}
