namespace DPM225465_Phạm_Ngọc_Quý_Myworld01_Bridge
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main(string[] args)
        {
            Abstraction remote = new RefinedAbstraction();

            // Set implementation and call
            remote.Implementor = new ConcreteImplementorA();
            remote.Operation();

            // Change implementation and call
            remote.Implementor = new ConcreteImplementorB();
            remote.Operation();

            // Wait for user
            Console.ReadKey();
        }
    }
}