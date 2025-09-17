using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225465_Phạm_Ngọc_Quý_Myworld01_AbstractFactory
{
     // Concrete Commando
    class Elf : Commando
    {
        public override void Fight(Evil enemy)
        {
            Console.WriteLine(this.GetType().Name + " fights " + enemy.GetType().Name);
        }
    }

}
