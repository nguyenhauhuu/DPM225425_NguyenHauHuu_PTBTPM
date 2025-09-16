using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225425_NguyenHauHuu_MyWorld01_AbstractFactory
{
    public class Africa : IContinentFactory
    {
        public IHerbivore CreateHerbivore() => new Wildebeest();
        public ICarnivore CreateCarnivore() => new Lion();
    }
}
