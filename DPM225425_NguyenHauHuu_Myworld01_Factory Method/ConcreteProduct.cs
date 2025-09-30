using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225465_Phạm_Ngọc_Quý_Myworld01_Factory_Method
{
    class ConcreteProductA : Product
    {
        public override string GetName()
        {
            return "Pizza Margherita";
        }
    }
    class ConcreteProductB : Product
    {
        public override string GetName()
        {
            return "Cappuccino Coffee";
        }
    }
}
