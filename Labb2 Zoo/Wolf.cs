namespace Labb2_Zoo
{
    internal class Wolf : Animal
    {
        public bool IsFemale { get; set; }
        public string FurColor { get; set; }

        public Wolf()
        {
            Name = "Otilldelad";
            Alive = true;
            Age = 0;
            Wild = true;
            Sick = false;
            Handler = "Otilldelad";
            Hungry = false;
            IsFemale = false;
            FurColor = "Otilldelad";
        }
    }
}
