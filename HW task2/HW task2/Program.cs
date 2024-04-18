namespace HW_task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal[] animals = new Animal[0];
            Cow moo = new Cow("Yayla");
            Lion shir = new Lion("Simba", true);
            foreach (var animal in animals)
            {
                if (animal is Lion)
                {
                    Lion lion = (Lion)animal;
                    lion.MakeSound();
                    lion.EatFood(new Meat("Et", 290));
                }
                else if (animal is Cow)
                {
                    Cow cow = (Cow)animal;
                    cow.MakeSound();
                    cow.EatFood(new Grass("sunbul", 140));
                    cow.ProduceMilk();
                }
            }
        }
    }
}
