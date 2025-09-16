using System;
namespace DPM225425_NguyenHauHuu_MyWorld01_AbstractFactory
{
    public class Program
    {
        public static void Main()
        {
            // Create and run the African animal world
            var africa = new IAnimalWorld<Africa>();
            africa.RunFoodChain();
            // Create and run the American animal world
            var america = new IAnimalWorld<America>();
            america.RunFoodChain();
            // Wait for user input
            ReadKey();
        }
    }
}
