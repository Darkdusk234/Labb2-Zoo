namespace Labb2_Zoo
{
    internal class Horse : Animal
    {
        public bool ContestWinner { get; set; }

        public Horse()
        {
            Name = "Otilldelad";
            Alive = true;
            Age = 0;
            Wild = true;
            Sick = false;
            Handler = "Otilldelad";
            Hungry = false;
            IsFemale = false;
            ContestWinner = false;
        }

        public Horse(string name, int age, bool wild, string handler, bool isFemale, bool contestWinner)
        {
            Name = name;
            Alive = true;
            Age = age;
            Wild = wild;
            Sick = false;
            Handler = handler;
            Hungry = false;
            IsFemale = isFemale;
            ContestWinner = contestWinner;
        }

        public void MakeSound()
        {
            Console.WriteLine("Neigh");
        }
    }
}
