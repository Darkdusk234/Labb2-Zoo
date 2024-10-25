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
    }
}
