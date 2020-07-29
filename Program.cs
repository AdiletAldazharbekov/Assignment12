using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    internal class Forest
    {
        private static readonly List<ObjectWithLocation> Objects = new List<ObjectWithLocation>();
        private static readonly List<LivingObject> LivingObjects = new List<LivingObject>();

        private static void Main()
        {
            // Populate forest
            var lake1 = new Lake(40, 40, 60, 60, 500);
            var stone1 = new Stone(20, 0, 0);

            Objects.Add(lake1);
            Objects.Add(stone1);

            LivingObject tree1 = new Tree(3, 10, 25);

            var animal1 = new Animal(3, 4);
            var bird1 = new Bird(1, 20);

            LivingObjects.Add(tree1);
            LivingObjects.Add(animal1);
            LivingObjects.Add(bird1);

            // Forest commands
            while (true)
            {
                Print();
                Console.WriteLine("");
                var input = Console.ReadLine();
                
                switch (input)
                {
                    case "next":
                        Continue();
                        break;

                    case "move":
                        var x = byte.Parse(Console.ReadLine());
                        var y = byte.Parse(Console.ReadLine());
                        animal1.Move(x, y);
                        bird1.Move(x, y);
                        
                        break;

                    default:
                        break;
                }
            }
        }
     
        private static void Print()
        {
            Console.WriteLine("\tStatus:");

            foreach (var obj in Objects)
            {
                Console.WriteLine($"{obj.GetType()}'s locations is {obj.Location}");
            }

            foreach (var obj in LivingObjects)
            {
                Console.WriteLine($"{obj.GetType()}'s locations is {obj.Location}, "+
                $"\tAlive? {obj.Alive}. Age: {obj.Age}");
            }
        }
        
        private static void Continue()
        {
            Console.WriteLine("\nOne year later...\n");

            foreach (var obj in LivingObjects)
            {
                obj.Grow();
            }
        }
    }
}