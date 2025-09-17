using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225465_Phạm_Ngọc_Quý_Myworld_Adapter
{
    public class Adapter : Target
    {
        private Adaptee adaptee = new Adaptee();

        public override void Request()
        {
            Console.WriteLine("Adapter converts JSON request to XML...");
            adaptee.SpecificRequest();
        }
    }

}
