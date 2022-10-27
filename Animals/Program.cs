namespace Animals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Fly fly = new Fly("Fly");
            fly.SaySomething();
            Console.WriteLine($"{fly.Name} has {fly.GetNumberOfLegs()} legs and weights {fly.GetWeightInG()} g.");
            fly.Eat();
            Console.WriteLine($"{fly.Name} weights {fly.GetWeightInG()} g after eating.");
            Duck duck = new Duck("Duck");
            duck.SaySomething();
            Console.WriteLine($"{duck.Name} has {duck.GetNumberOfLegs()} legs and weights {duck.GetWeightInG()} g.");
            duck.Eat();
            Console.WriteLine($"{duck.Name} weights {duck.GetWeightInG()} g after eating.");
            Lizzard lizzard = new Lizzard("Lizzard");
            lizzard.SaySomething();
            Console.WriteLine($"{lizzard.Name} has {lizzard.GetNumberOfLegs()} legs and weights {lizzard.GetWeightInG()} g.");
            lizzard.Eat();
            Console.WriteLine($"{lizzard.Name} weights {lizzard.GetWeightInG()} g after eating.");
            Elephant elephant = new Elephant("Elephant");
            elephant.SaySomething();
            Console.WriteLine($"{elephant.Name} has {elephant.GetNumberOfLegs()} legs and weights {elephant.GetWeightInG()} g.");
            elephant.Eat();
            Console.WriteLine($"{elephant.Name} weights {elephant.GetWeightInG()} g after eating.");
            Worm worm = new Worm("Worm");
            worm.SaySomething();
            Console.WriteLine($"{worm.Name} has {worm.GetNumberOfLegs()} legs and weights {worm.GetWeightInG()} g.");
            worm.Eat();
            Console.WriteLine($"{worm.Name} weights {worm.GetWeightInG()} g after eating.");


        }
    }
}