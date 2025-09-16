using DPM225425_NguyenHauHuu_MyWorld01_AbstractFactory.Factories;
using DPM225425_NguyenHauHuu_MyWorld01_AbstractFactory.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225425_NguyenHauHuu_MyWorld01_AbstractFactory
{
    public class IAnimalWorld<T> : IAnimalWorld where T : IContinentFactory, new()
    {
        private readonly IHerbivore herbivore;
        private readonly ICarnivore carnivore;
        public IAnimalWorld()
        {
            // Create new continent factory
            var factory = new T();
            // Factory creates carnivores and herbivores
            carnivore = factory.CreateCarnivore();
            herbivore = factory.CreateHerbivore();
        }
        /// <summary>
        /// Runs the foodchain: carnivores are eating herbivores.
        /// </summary>
        public void RunFoodChain()
        {
            carnivore.Eat(herbivore);
        }
    }
}
