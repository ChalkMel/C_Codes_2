using System;
using System.IO;
using MelnikVictoria_CatFramework;

namespace MelnikVictoria_CatApplication
{
    internal class Program
    {
        private static readonly Random Rand = new Random();

        static void Main()
        {
            Console.Write("Введите количество котов: ");
            if (!uint.TryParse(Console.ReadLine(), out uint catCount))
            {
                Console.WriteLine("Некорректное число.");
                return;
            }

            Cat[] cats = GenerateRandomCats(catCount);

            Console.Write("Введите путь к файлу: ");
            string path = Console.ReadLine();

            DisplayCatInfo(cats, path);
        }

        static Cat[] GenerateRandomCats(uint count)
        {
            Cat[] result = new Cat[count];

            for (uint i = 0; i < count; i++)
            {
                while (true)
                {
                    try
                    {
                        int fluffiness = Rand.Next(-20, 121);

                        if (Rand.Next(2) == 0)
                        {
                            double weight = 50 + Rand.NextDouble() * 110;
                            result[i] = new Tiger(weight, fluffiness);
                        }
                        else
                        {
                            result[i] = new CuteCat(fluffiness);
                        }

                        break;
                    }
                    catch (CatException ex)
                    {
                        Console.WriteLine($"Возникло исключение: {ex.Message}");
                    }
                }
            }

            return result;
        }

        static void DisplayCatInfo(Cat[] catsArr, string path)
        {
            using StreamWriter writer = new StreamWriter(path, append: false);

            foreach (Cat cat in catsArr)
            {
                string check = cat.FluffinessCheck();
                string info  = cat.ToString();

                Console.WriteLine(check);
                Console.WriteLine(info);

                writer.WriteLine(check);
                writer.WriteLine(info);
            }
        }
    }
}