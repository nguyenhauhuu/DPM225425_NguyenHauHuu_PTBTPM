using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225465_Phạm_Ngọc_Quý_Myworld01_Builder
{
    class Director
    {
        public void Construct(Builder builder)
        {
            builder.BuildPartA(); // Build CPU + RAM
            builder.BuildPartB(); // Build GPU + Storage
        }
    }
}
