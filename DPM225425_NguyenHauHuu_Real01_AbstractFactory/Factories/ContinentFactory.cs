using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DPM225425_NguyenHauHuu_Real01_AbstractFactory.Products;

namespace DPM225425_NguyenHauHuu_Real01_AbstractFactory.Factories
{
    abstract class ContinentFactory
    {
        public abstract Herbivore CreateHerbivore();
        public abstract Carnivore CreateCarnivore();
    }
}
