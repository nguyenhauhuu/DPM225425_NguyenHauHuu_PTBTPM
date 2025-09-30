namespace DPM225465_Phạm_Ngọc_Quý_Myworld01_Prototype
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main(string[] args)
        {
            // Create two instances and clone each

            ConcretePrototype1 doc1 = new ConcretePrototype1("Document_01.docx");
            ConcretePrototype1 doc2 = (ConcretePrototype1)doc1.Clone();
            Console.WriteLine("Cloned Document: {0}", doc2.Id);

            ConcretePrototype2 img1 = new ConcretePrototype2("Image_01.png");
            ConcretePrototype2 img2 = (ConcretePrototype2)img1.Clone();
            Console.WriteLine("Cloned Image: {0}", img2.Id);

            // Wait for user
            Console.ReadKey();
        }
    }
}