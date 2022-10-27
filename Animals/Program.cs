namespace Animals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Fly fly = new Fly("Fly");
            fly.SaySomething();
            Console.WriteLine($"{fly.Name} has {fly.HowManyLegsDoYouHave()} legs and weights {fly.WeightInKg} kg.");
            Duck duck = new Duck("Duck");
            duck.SaySomething();
            Console.WriteLine($"{duck.Name} has {duck.HowManyLegsDoYouHave()} legs and weights {duck.WeightInKg} kg.");
            Lizzard lizzard = new Lizzard("Lizzard");
            lizzard.SaySomething();
            Console.WriteLine($"{lizzard.Name} has {lizzard.HowManyLegsDoYouHave()} legs and weights {lizzard.WeightInKg} kg.");
            Elephant elephant = new Elephant("Elephant");
            elephant.SaySomething();
            Console.WriteLine($"{elephant.Name} has {elephant.HowManyLegsDoYouHave()} legs and weights {elephant.WeightInKg} kg.");
            Worm worm = new Worm("Worm");
            worm.SaySomething();
            Console.WriteLine($"{worm.Name} has {worm.HowManyLegsDoYouHave()} legs and weights {worm.WeightInKg} kg.");
        }
    }
}