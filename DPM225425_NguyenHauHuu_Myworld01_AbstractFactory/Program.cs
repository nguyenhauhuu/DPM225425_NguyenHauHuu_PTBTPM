namespace DPM225465_Phạm_Ngọc_Quý_Myworld01_AbstractFactory
{
    internal static class Program
    {
        public static void Main()
        {
            // Create and run the African animal world
            WorldFactory factory = new FantasyWorldFactory();
            GameWorld game = new GameWorld(factory);
            game.StartBattle();
            Console.ReadKey();
        }
    }
}