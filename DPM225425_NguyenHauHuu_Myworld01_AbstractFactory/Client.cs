using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225465_Phạm_Ngọc_Quý_Myworld01_AbstractFactory
{
    // Game World (Tương tự AnimalWorld)
    class GameWorld
    {
        private Commando _commando;
        private Evil _evil;

        // Constructor
        public GameWorld(WorldFactory factory)
        {
            _evil = factory.CreateEvil();
            _commando = factory.CreateCommando();
        }

        public void StartBattle()
        {
            _commando.Fight(_evil);
        }
    }
}
