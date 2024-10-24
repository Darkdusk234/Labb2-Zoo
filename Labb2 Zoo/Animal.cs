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
        private bool _hungry;

        public virtual void Feed()
        {
            _hungry = false;
            Console.WriteLine($"{Name} fick mat.");
        }

        public virtual void LogDeath(string causeOfDeath)
        {
            Alive = false;
            Console.WriteLine($"{Name} dog av {causeOfDeath}");
        }

        public void LogSickness()
        {
            Sick = true;
            Console.WriteLine($"{Name} är sjuk.");
        }
    }
}
