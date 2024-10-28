namespace Labb2_Zoo
{
    internal class Wolf : Animal
    {
        public string FurColor { get; set; } = "Otilldelad";

        public Wolf()
        {
           
        }

        public Wolf(string name, int age, bool wild, string handler, bool isFemale, string furColor)
        {
            Name = name;
            Age = age;
            Wild = wild;
            Handler = handler;
            IsFemale = isFemale;
            FurColor = furColor;
        }

        public void MakeSound()
        {
            Console.WriteLine("OwoOoooOo");
        }

        public void PawPrint()
        {
            Console.WriteLine("  ^ ^ \r\n^ XXX ^\r\nXXXXXXX\r\n XXXXX");
        }
    }
}
