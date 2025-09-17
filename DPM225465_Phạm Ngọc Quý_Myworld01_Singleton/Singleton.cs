using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225465_Phạm_Ngọc_Quý_Myworld01_Singleton
{
    public class Singleton
    {
        static Singleton instance;

        // Properties to simulate real configuration
        public string AppName { get; set; }
        public string Version { get; set; }

        // Constructor is 'protected'
        protected Singleton()
        {
            // default values
            AppName = "Default App";
            Version = "0.0.1";
        }

        public static Singleton Instance()
        {
            // Uses lazy initialization.
            // Note: this is not thread safe.
            if (instance == null)
            {
                instance = new Singleton();
            }

            return instance;
        }
    }
}
