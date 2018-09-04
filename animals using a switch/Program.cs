using System;

namespace animals_using_a_switch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Pick a number: ");
            int number = int.Parse(Console.ReadLine());
            string animal;

            switch (number)
            {
                case 0: animal = "Cat"; break;
                case 1: animal = "Dog"; break;
                case 2: animal = "Duck"; break;
                case 3: animal = "Unicorn"; break;
                case 4: animal = "Griffin"; break;
                case 5: animal = "Hippogriff"; break;
                case 6: animal = "Anteater"; break;
                case 7: animal = "Chicken"; break;
                case 8: animal = "Alligator"; break;
                case 9: animal = "Cardinal"; break;
                case 10: animal = "Sheep"; break;
                default: animal = "No animal"; break;
            }

            Console.WriteLine($"You chose: {animal}.");
            Console.ReadLine();

        }
    }
}
