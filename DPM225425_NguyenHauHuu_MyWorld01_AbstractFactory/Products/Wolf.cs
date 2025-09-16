using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225425_NguyenHauHuu_MyWorld01_AbstractFactory
{
    public class Wolf : ICarnivore
    {
        // Eat Bison
        public void Eat(IHerbivore h) =>
            WriteLine($"{GetType().Name} eats {h.GetType().Name}");
    }
}
