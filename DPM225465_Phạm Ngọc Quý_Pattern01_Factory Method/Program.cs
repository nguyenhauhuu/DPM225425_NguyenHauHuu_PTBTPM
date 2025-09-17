namespace DPM225465_Phạm_Ngọc_Quý_Pattern01_Factory_Method
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // An array of creators
            Creator[] creators = new Creator[2];
            creators[0] = new ConcreteCreatorA();
            creators[1] = new ConcreteCreatorB();
            // Iterate over creators and create products
            foreach (Creator creator in creators)
            {
                Product product = creator.FactoryMethod();
                Console.WriteLine("Created {0}",
                  product.GetType().Name);
            }
            // Wait for user
            Console.ReadKey();
            Console.WriteLine("Done!");
            Console.ReadKey();
        }
    }
}