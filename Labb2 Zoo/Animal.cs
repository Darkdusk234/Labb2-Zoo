namespace Labb2_Zoo
{
    internal class Animal
    {
        public bool Alive { get; set; }
        public int Age { get; set; }
        public bool Wild { get; set; }
        public bool Sick { get; set; }
        public string Handler { get; set; }
        private bool _hungry;

        public virtual void Feed()
        {
            _hungry = false;
            Console.WriteLine("Djuret fick mat.");
        }


    }
}
