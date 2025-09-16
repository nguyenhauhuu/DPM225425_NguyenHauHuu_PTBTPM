namespace DPM225425_NguyenHauHuu_Real01_AbstractFactory.Products
{
    class Wolf : Carnivore
    {
        public override void Eat(Herbivore h)
        {
            // Eat Bison
            Console.WriteLine(GetType().Name +
              " eats " + h.GetType().Name);
        }
    }

}
