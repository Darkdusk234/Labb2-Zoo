namespace Labb2_Zoo
{
    internal class Animal
    {
        public string Name { get; set; }
        public bool Alive { get; set; }
        public int Age { get; set; }
        public bool Wild { get; set; }
        public bool Sick { get; set; }
        public string Handler { get; set; }
        public bool Hungry { get; set; }

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
