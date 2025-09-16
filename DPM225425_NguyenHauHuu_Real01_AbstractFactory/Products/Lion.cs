namespace DPM225425_NguyenHauHuu_Real01_AbstractFactory.Products
{
    class Lion : Carnivore
    {
        public override void Eat(Herbivore h)
        {
            // Eat Wildebeest
            Console.WriteLine(GetType().Name +
              " eats " + h.GetType().Name);
        }
    }
}
