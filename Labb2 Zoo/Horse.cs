namespace Labb2_Zoo
{
    internal class Horse : Animal
    {
        public bool ContestWinner { get; set; } = false;

        public Horse()
        {
            
        }

        public Horse(string name, int age, bool wild, string handler, bool isFemale, bool contestWinner)
        {
            Name = name;
            Age = age;
            Wild = wild;
            Handler = handler;
            IsFemale = isFemale;
            ContestWinner = contestWinner;
        }

        public void MakeSound()
        {
            Console.WriteLine("Neigh");
        }

        public void ContestWin()
        {
            ContestWinner = true;
            Console.WriteLine($"{Name} vann en medalj.");
        }
    }
}
