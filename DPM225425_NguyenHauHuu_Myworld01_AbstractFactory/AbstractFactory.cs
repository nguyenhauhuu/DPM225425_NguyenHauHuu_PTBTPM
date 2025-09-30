using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225465_Phạm_Ngọc_Quý_Myworld01_AbstractFactory
{
    abstract class WorldFactory
    {
        public abstract Evil CreateEvil();
        public abstract Commando CreateCommando();
    }
}
