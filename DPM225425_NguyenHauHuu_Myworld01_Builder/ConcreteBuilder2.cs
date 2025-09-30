using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225465_Phạm_Ngọc_Quý_Myworld01_Builder
{
    class GamingComputerBuilder : Builder
    {
        private Computer _computer = new Computer();

        public override void BuildPartA()
        {
            _computer.Add("Intel Core i9 CPU");
            _computer.Add("32GB RAM");
        }

        public override void BuildPartB()
        {
            _computer.Add("NVIDIA RTX 4090 GPU");
            _computer.Add("2TB NVMe SSD");
        }

        public override Computer GetResult()
        {
            return _computer;
        }
    }
}
