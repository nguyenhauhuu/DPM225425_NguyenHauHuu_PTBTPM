using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225465_Phạm_Ngọc_Quý_Myworld01_Builder
{
    class OfficeComputerBuilder : Builder
    {
        private Computer _computer = new Computer();

        public override void BuildPartA()
        {
            _computer.Add("Intel Core i5 CPU");
            _computer.Add("8GB RAM");
        }

        public override void BuildPartB()
        {
            _computer.Add("Integrated Graphics");
            _computer.Add("256GB SSD");
        }

        public override Computer GetResult()
        {
            return _computer;
        }
    }
}
