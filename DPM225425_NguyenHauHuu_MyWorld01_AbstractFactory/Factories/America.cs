using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225425_NguyenHauHuu_MyWorld01_AbstractFactory
{
    public class America : IContinentFactory
    {
        public IHerbivore CreateHerbivore() => new Bison();
        public ICarnivore CreateCarnivore() => new Wolf();
    }
}
