namespace Flyweight
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            var forest = new Forest();
            forest.PlantTree(15, 10, "Coconut", "White");
            forest.PlantTree(7, 4, "Honey locust", "Yellow");
            forest.PlantTree(7, 6, "American sycamore", "Yellow");

            forest.Draw(Guid.NewGuid().ToString());

            Console.ReadKey();
        }
    }
}
