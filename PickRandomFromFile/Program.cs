using System;
using System.IO;

namespace PickRandomFromFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string randomFood, randomDrink, randomMovie;
            randomFood = GetRandomFromFileFood("foods.text");
            randomDrink = GetRandomFromFileDrink("drinks.text");
            randomMovie = GetRandomFromFileMovie("movie.text");

            Console.WriteLine($"Tonight you will have some {randomFood} with {randomDrink} and watch {randomMovie} ");


        }

        private static int GenerateRandomIndex(string[] someArray)
        {
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, someArray.Length);
            return randomIndex;
        }

        private static string GetRandomFromFileFood(string fileName)
        {
            string filePath = $@"C:\Users\...\samples\foods.txt";
            string[] dataFromFile = File.ReadAllLines(filePath);
            string randomElement = dataFromFile[GenerateRandomIndex(dataFromFile)];

            return randomElement;
        }

        private static string GetRandomFromFileDrink(string fileName)
        {
            string filePath = $@"C:\Users\...\samples\drinks.txt";
            string[] dataFromFile = File.ReadAllLines(filePath);
            string randomElement = dataFromFile[GenerateRandomIndex(dataFromFile)];

            return randomElement;

        }

        private static string GetRandomFromFileMovie(string fileName)
        {
            string filePath = $@"C:\Users\...\samples\movies.txt";
            string[] dataFromFile = File.ReadAllLines(filePath);
            string randomElement = dataFromFile[GenerateRandomIndex(dataFromFile)];

            return randomElement;
        }

    }
}
