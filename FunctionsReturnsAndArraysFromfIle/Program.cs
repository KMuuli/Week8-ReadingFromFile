using System;

namespace FunctionsReturnsAndArraysFromfIle
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplayRandomFood();
            DisplayRandomDrink();
            DisplayRandomMovie();
        }

        private static void DisplayRandomFood()
        {
            string[] foods = { "popcorn", "sushi", "chicken wings", "pizza", "salad" };
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, foods.Length);

            string randomFood = foods[randomIndex];
            Console.WriteLine($"Computer picked:{randomFood}");
        }

        private static void DisplayRandomDrink()
        {
            string[] drinks = { "apple juice", "coke", "fanta", "sprite" };
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, drinks.Length);

            string randomDrink = drinks[randomIndex];
            Console.WriteLine($"Computer picked:{randomDrink}");
        }
        
        private static void DisplayRandomMovie()
        {
            string[] movie = { "Top Gun", "Rambo", "Fast and Furious Franchise", "Pirates of the Carribean", "JOKER" };
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, movie.Length);

            string randomMovie = movie[randomIndex];
            Console.WriteLine($"Computer picked:{randomMovie}");
        }


    }
}
