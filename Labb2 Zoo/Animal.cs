namespace Labb2_Zoo
{
    internal class Animal
    {
        public string Name { get; set; } = "Otilldelad";
        public bool Alive { get; set; } = true;
        public int Age { get; set; } = 0;
        public bool Wild { get; set; } = true;
        public bool Sick { get; set; } = false;
        public string Handler { get; set; } = "Otilldelad";
        public bool Hungry { get; set; } = false;
        public bool IsFemale { get; set; } = false;

        public void Feed()
        {
            Hungry = false;
            Console.WriteLine($"{Name} fick mat.");
        }

        public void LogDeath(string causeOfDeath)
        {
            Alive = false;
            Console.WriteLine($"{Name} dog av {causeOfDeath}");
        }

        public void LogSickness()
        {
            Sick = true;
            Console.WriteLine($"{Name} är sjuk.");
        }

        public void Treatment()
        {
            Sick = false;
            Console.WriteLine($"{Name} är frisk igen.");
        }
    }
}
