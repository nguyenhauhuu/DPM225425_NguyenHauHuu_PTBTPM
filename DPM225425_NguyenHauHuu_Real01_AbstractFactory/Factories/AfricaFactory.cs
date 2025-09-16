using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DPM225425_NguyenHauHuu_Real01_AbstractFactory.Products;

namespace DPM225425_NguyenHauHuu_Real01_AbstractFactory.Factories
{
    class AfricaFactory : ContinentFactory
    {
        public override Herbivore CreateHerbivore()
        {
            return new Wildebeest();
        }
        public override Carnivore CreateCarnivore()
        {
            return new Lion();
        }
    }

}
