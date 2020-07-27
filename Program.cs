using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Forest
    {
        readonly static List<ObjectWithLocation> Objects = new List<ObjectWithLocation>();
        readonly static List<LivingObject> LivingObjects = new List<LivingObject>();

        static void Main()
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
                        break;
                    default:
                        break;
                }
            }
        }

        static void Continue()
        {
            Console.WriteLine("\nOne year later...\n");

            foreach (var obj in LivingObjects)
            {
                obj.Grow();
            }
        }

        static void Print()
        {
            Console.WriteLine("Satus:\n");

            foreach (var obj in Objects)
            {
                Console.WriteLine($"{obj.GetType()}'s locations is {obj.Location}");
            }

            foreach (var obj in LivingObjects)
            {
                Console.WriteLine($"{obj.GetType()}'s locations is {obj.Location}");
                Console.WriteLine($"\tAlive? {obj.Alive}. Age: {obj.Age}");
            }
        }
    }

}