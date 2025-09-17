using Microsoft.VisualBasic.Devices;
using System.IO;

namespace DPM225465_Phạm_Ngọc_Quý_Myworld01_Builder
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Create director and builders
            Director director = new Director();

            Builder officeBuilder = new OfficeComputerBuilder();
            Builder gamingBuilder = new GamingComputerBuilder();

            // Build office computer
            director.Construct(officeBuilder);
            Computer officePC = officeBuilder.GetResult();
            officePC.Show();

            // Build gaming computer
            director.Construct(gamingBuilder);
            Computer gamingPC = gamingBuilder.GetResult();
            gamingPC.Show();

            Console.ReadKey();
        }
    }
}