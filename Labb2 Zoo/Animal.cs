namespace Labb2_Zoo
{
    internal class Animal
    {
        public bool Alive { get; set; }
        public int Age { get; set; }
        public bool Wild { get; set; }
        public bool Sick { get; set; }

        public string Handler { get; set; }

        public virtual void Feed()
        {
            Console.WriteLine("Djuret fick mat.");
        }
    }
}
