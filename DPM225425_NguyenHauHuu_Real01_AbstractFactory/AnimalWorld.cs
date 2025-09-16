using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DPM225425_NguyenHauHuu_Real01_AbstractFactory.Factories;
using DPM225425_NguyenHauHuu_Real01_AbstractFactory.Products;

namespace DPM225425_NguyenHauHuu_Real01_AbstractFactory
{
    class AnimalWorld
    {
        private Herbivore _herbivore;
        private Carnivore _carnivore;
        // Constructor
        public AnimalWorld(ContinentFactory factory)
        {
            _carnivore = factory.CreateCarnivore();
            _herbivore = factory.CreateHerbivore();
        }
        public void RunFoodChain()
        {
            _carnivore.Eat(_herbivore);
        }
    }
}
