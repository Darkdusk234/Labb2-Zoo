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

        public Wolf(string name, int age, bool wild, string handler, bool isFemale, string furColor)
        {
            Name = name;
            Alive = true;
            Age = age;
            Wild = wild;
            Sick = false;
            Handler = handler;
            Hungry = false;
            IsFemale = isFemale;
            FurColor = furColor;
        }

        public void MakeSound()
        {
            Console.WriteLine("OwoOoooOo");
        }
    }
}
