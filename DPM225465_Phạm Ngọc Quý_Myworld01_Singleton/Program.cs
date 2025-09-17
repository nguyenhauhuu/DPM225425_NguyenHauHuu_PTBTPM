namespace DPM225465_Phạm_Ngọc_Quý_Myworld01_Singleton
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main(string[] args)
        {
            // Constructor is protected -- cannot use new

            Singleton config1 = Singleton.Instance();
            Singleton config2 = Singleton.Instance();

            // Test for same instance
            if (config1 == config2)
            {
                Console.WriteLine("Objects are the same instance");
            }

            // Set configuration in one place
            config1.AppName = "Music Player";
            config1.Version = "1.0.0";

            // Access configuration from another place
            Console.WriteLine("Application: {0}, Version: {1}",
                config2.AppName, config2.Version);

            // Wait for user
            Console.ReadKey();
        }
    }
}